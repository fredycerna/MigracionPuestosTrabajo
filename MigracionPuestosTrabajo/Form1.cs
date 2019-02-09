using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MigracionPuestosTrabajo.Data;

namespace MigracionPuestosTrabajo
{
    public partial class Form1 : Form
    {
        
        private string filepath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (dlgabrir.ShowDialog()== DialogResult.OK)
            {
                lbfile.Text = dlgabrir.FileName;
                this.filepath = lbfile.Text;
            }
        }
        
        // ingresar encabezado ID 
        private void button1_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("titulo", "Titulo");
            dgvdata.Columns.Add("objetivo", "Objetivo");

            try
            {
               
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                var count = 1;
                List<PuestosTrabajo> puestosList = new List<PuestosTrabajo>();
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }
                    PuestosTrabajo puestosTrabajo = new PuestosTrabajo();

                    //MessageBox.Show(hoja.Name);
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puestosTrabajo.Titulo = xlRange.Cells[2, 2].Value2.ToString();
                    puestosTrabajo.Objetivo = xlRange.Cells[9, 2].Value2.ToString();
                    puestosTrabajo.FechaCreacion = DateTime.Now;
                    puestosTrabajo.UnidadID = 1;
                    puestosList.Add(puestosTrabajo);

                    dgvdata.Rows.Add(hoja.Name, xlRange.Cells[2, 2].Value2.ToString(), xlRange.Cells[9, 2].Value2.ToString());

                    lbltotal.Text = dgvdata.RowCount.ToString();
                    count++;
                }
                
                libro.Close();
                excel.Quit();

                using (var modelo = new Data.PerfilesModel())
                {
                    modelo.PuestosTrabajoes.AddRange(puestosList);
                    modelo.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }              
         

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //string fecha = DateTime.Now.ToString();
            
            //MessageBox.Show(fecha);

        }

        //no se utiliza
        private void btnprocesar_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        //obtener datos de la tabla (no utilizado)
        public void ObtenerDatos()
        {

            for (int fila = 0; fila < dgvdata.Rows.Count - 1; fila++)
            {
                PuestosTrabajo puestosTrabajo = new PuestosTrabajo();

                for (int columna = 0; columna < dgvdata.Rows[fila].Cells.Count; columna++)
                {
                    string datos = dgvdata.Rows[fila].Cells[columna].Value.ToString();

                    puestosTrabajo.Titulo = datos;
                    
                    //MessageBox.Show(datos);
                }
            }

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            funciones.Show();
        }

        //ingresar funciones (ID 4)
        private void btnFunciones_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("funciones", "Funciones");

            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 42, ff = 66;
                string puesto = string.Empty;
                string funcion = string.Empty;
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestodtrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst => pst.Titulo.Equals(puesto));                        

                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            funcion = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add(puesto, funcion);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo {
                                Description = funcion,
                                PuestoTrabajoId = puestodtrabajo.PuestoTrabajoID,
                                SubCategoriaId = 4
                            });
                        }

                        modelo.SaveChanges();

                    }

                    count++;
                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        //formacion (ID 1)
        private void btnFormacion_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("formacion", "Formación");

            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 11, ff = 20; // inicio, fin de celdas
                string puesto = string.Empty; //puesto trabajo 
                string formacion = string.Empty; //formacion academica
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }

                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString(); //puesto de trabajo

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst => pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            formacion = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add(puesto, formacion);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description = formacion,
                                PuestoTrabajoId = puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId = 1
                            });
                        }
                        modelo.SaveChanges();
                    }

                    count++;
                   

                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        //ingresar experiencia (ID 2)
        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("experiencia", "Experiencia");
            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 21, ff = 30;
                string puesto = string.Empty;
                string experiencia = string.Empty;
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst => pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            experiencia = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add(puesto, experiencia);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description = experiencia,
                                PuestoTrabajoId = puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId= 2
                            });

                         }
                        modelo.SaveChanges();
                    }

                    count++;
                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        //ingresar complementos(ID 3)
        private void btnComplementos_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("complementos", "Complementos");
            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 31, ff = 40;
                string puesto = string.Empty;
                string complementos = string.Empty;
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();
                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst => pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            complementos = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add(puesto, complementos);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description = complementos,
                                PuestoTrabajoId= puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId = 3 
                            });
                        }
                        modelo.SaveChanges();
                    }
                    count++;
                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        //ingresar Conocimientos(ID 5)
        private void btnConocimientos_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("conocimientos", "Conocimientos");
            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 68, ff = 82;
                string puesto = string.Empty;
                string conocimientos = string.Empty;
                var count = 1;

                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count >= libro.Sheets.Count)
                    {
                        break;
                    }

                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst => pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            conocimientos = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add( puesto, conocimientos);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description = conocimientos,
                                PuestoTrabajoId = puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId= 5
                            });
                        }
                        modelo.SaveChanges();
                    }

                    count++;

                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        //ingresar habilidades (ID 6)
        private void btnHabilidades_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("habilidades", "Habilidades");
            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 84, ff = 108;
                string puesto = string.Empty;
                string habilidades = string.Empty;
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count>= libro.Sheets.Count)
                    {
                        break;
                    }
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst=>pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            habilidades = xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add( puesto, habilidades);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description=habilidades,
                                PuestoTrabajoId = puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId = 6
                            });
                        }
                        modelo.SaveChanges();
                    }

                    count++;


                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }

        // ingresar condiciones (ID 7)
        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("condiciones", "Condiciones");
            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 110, ff = 129;
                string puesto = string.Empty;
                string condiciones = string.Empty;
                var count = 1;
                foreach (Worksheet hoja in libro.Sheets)
                {
                    if (count>= libro.Sheets.Count)
                    {
                        break;
                    }
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();

                    using (var modelo = new Data.PerfilesModel())
                    {
                        var puestotrabajo = modelo.PuestosTrabajoes.FirstOrDefault(pst=> pst.Titulo.Equals(puesto));
                        for (int f = fi; f <= ff; f++)
                        {
                            if (xlRange.Cells[f, 2].Value2 == null)
                                break;
                            condiciones =xlRange.Cells[f, 2].Value2.ToString();
                            dgvdata.Rows.Add( puesto, condiciones);

                            modelo.ElementosPuestoTrabajoes.Add(new ElementosPuestoTrabajo
                            {
                                Description= condiciones,
                                PuestoTrabajoId= puestotrabajo.PuestoTrabajoID,
                                SubCategoriaId= 7
                            });
                        }
                        modelo.SaveChanges();
                    }

                    count++;

                }
                libro.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer excel file " + ex.Message);
                excel.Quit();
            }
        }
    }
}
