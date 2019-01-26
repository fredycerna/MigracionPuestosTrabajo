namespace MigracionPuestosTrabajo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncargar = new System.Windows.Forms.Button();
            this.lbfile = new System.Windows.Forms.Label();
            this.dlgabrir = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(26, 32);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 0;
            this.btncargar.Text = "Cargar Archivo";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // lbfile
            // 
            this.lbfile.AutoSize = true;
            this.lbfile.Location = new System.Drawing.Point(126, 37);
            this.lbfile.Name = "lbfile";
            this.lbfile.Size = new System.Drawing.Size(10, 13);
            this.lbfile.TabIndex = 1;
            this.lbfile.Text = "-";
            // 
            // dlgabrir
            // 
            this.dlgabrir.Filter = "Excel files | *.xlsx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Leer Puestos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(26, 128);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(746, 240);
            this.dgvdata.TabIndex = 3;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(603, 374);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(169, 23);
            this.btnprocesar.TabIndex = 4;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(26, 375);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 13);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Funciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbfile);
            this.Controls.Add(this.btncargar);
            this.Name = "Form1";
            this.Text = "Migracion de Puestos de Trabajo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Label lbfile;
        private System.Windows.Forms.OpenFileDialog dlgabrir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button2;
    }
}

