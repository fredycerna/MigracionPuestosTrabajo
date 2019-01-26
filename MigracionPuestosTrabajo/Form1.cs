using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


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

        private void button1_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                foreach (Worksheet hoja in libro.Sheets)
                {               
                    //MessageBox.Show(hoja.Name);
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    //MessageBox.Show(xlRange.Cells[2, 2].Value2.ToString());
                    //MessageBox.Show(xlRange.Cells[9, 2].Value2.ToString());
                    dgvdata.Rows.Add(hoja.Name, xlRange.Cells[2, 2].Value2.ToString(), xlRange.Cells[9, 2].Value2.ToString());
                    lbltotal.Text = dgvdata.RowCount.ToString();
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

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvdata.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvdata.Columns.Add("titulo", "Titulo");
            dgvdata.Columns.Add("objetivo", "Objetivo");

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        public void ObtenerDatos()
        {

            for (int fila = 0; fila < dgvdata.Rows.Count - 1; fila++)
            {
                for (int columna = 0; columna < dgvdata.Rows[fila].Cells.Count; columna++)
                {
                    string datos = dgvdata.Rows[fila].Cells[columna].Value.ToString();
                    //MessageBox.Show(valor);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            funciones.Show();
        }
    }
}
