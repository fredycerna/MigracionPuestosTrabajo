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
    public partial class Funciones : Form
    {
        private string filepath;
        public Funciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                lblRuta.Text = dlgAbrir.FileName;
                this.filepath = lblRuta.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                Workbook libro = excel.Workbooks.Open(this.filepath);
                excel.Visible = false;
                int fi = 42, ff = 66;
                string puesto = string.Empty;
                string funcion = string.Empty;

                foreach (Worksheet hoja in libro.Sheets)
                {
                    Microsoft.Office.Interop.Excel.Range xlRange = hoja.UsedRange;
                    puesto = xlRange.Cells[2, 2].Value2.ToString();
                    
                    for (int f =fi; f<=ff; f++)
                    {
                        if (xlRange.Cells[f, 2].Value2 == null)
                            break;
                        funcion = puesto = xlRange.Cells[f, 2].Value2.ToString();                       
                        dgvData.Rows.Add(hoja.Name, puesto, funcion);
                    }
                 
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

        private void Funciones_Load(object sender, EventArgs e)
        {
            dgvData.Columns.Add("nombre", "Nombre"); //Nombre de la hoja
            dgvData.Columns.Add("funciones", "Funciones");
        }
    }
}
