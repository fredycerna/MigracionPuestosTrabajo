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
            this.btnFunciones = new System.Windows.Forms.Button();
            this.btnFormacion = new System.Windows.Forms.Button();
            this.btnExperiencia = new System.Windows.Forms.Button();
            this.btnComplementos = new System.Windows.Forms.Button();
            this.btnConocimientos = new System.Windows.Forms.Button();
            this.btnHabilidades = new System.Windows.Forms.Button();
            this.btnCondiciones = new System.Windows.Forms.Button();
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
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = " Puestos";
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
            // btnFunciones
            // 
            this.btnFunciones.Location = new System.Drawing.Point(92, 98);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(68, 23);
            this.btnFunciones.TabIndex = 7;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.UseVisualStyleBackColor = true;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnFormacion
            // 
            this.btnFormacion.Location = new System.Drawing.Point(166, 98);
            this.btnFormacion.Name = "btnFormacion";
            this.btnFormacion.Size = new System.Drawing.Size(134, 23);
            this.btnFormacion.TabIndex = 8;
            this.btnFormacion.Text = "Formación academica";
            this.btnFormacion.UseVisualStyleBackColor = true;
            this.btnFormacion.Click += new System.EventHandler(this.btnFormacion_Click);
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.Location = new System.Drawing.Point(307, 97);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.Size = new System.Drawing.Size(115, 23);
            this.btnExperiencia.TabIndex = 9;
            this.btnExperiencia.Text = "Experiencia laboral";
            this.btnExperiencia.UseVisualStyleBackColor = true;
            this.btnExperiencia.Click += new System.EventHandler(this.btnExperiencia_Click);
            // 
            // btnComplementos
            // 
            this.btnComplementos.Location = new System.Drawing.Point(429, 98);
            this.btnComplementos.Name = "btnComplementos";
            this.btnComplementos.Size = new System.Drawing.Size(84, 23);
            this.btnComplementos.TabIndex = 10;
            this.btnComplementos.Text = "Complementos";
            this.btnComplementos.UseVisualStyleBackColor = true;
            this.btnComplementos.Click += new System.EventHandler(this.btnComplementos_Click);
            // 
            // btnConocimientos
            // 
            this.btnConocimientos.Location = new System.Drawing.Point(520, 98);
            this.btnConocimientos.Name = "btnConocimientos";
            this.btnConocimientos.Size = new System.Drawing.Size(83, 23);
            this.btnConocimientos.TabIndex = 11;
            this.btnConocimientos.Text = "Conocimientos";
            this.btnConocimientos.UseVisualStyleBackColor = true;
            this.btnConocimientos.Click += new System.EventHandler(this.btnConocimientos_Click);
            // 
            // btnHabilidades
            // 
            this.btnHabilidades.Location = new System.Drawing.Point(610, 97);
            this.btnHabilidades.Name = "btnHabilidades";
            this.btnHabilidades.Size = new System.Drawing.Size(75, 23);
            this.btnHabilidades.TabIndex = 12;
            this.btnHabilidades.Text = "Habilidades";
            this.btnHabilidades.UseVisualStyleBackColor = true;
            this.btnHabilidades.Click += new System.EventHandler(this.btnHabilidades_Click);
            // 
            // btnCondiciones
            // 
            this.btnCondiciones.Location = new System.Drawing.Point(692, 98);
            this.btnCondiciones.Name = "btnCondiciones";
            this.btnCondiciones.Size = new System.Drawing.Size(75, 23);
            this.btnCondiciones.TabIndex = 13;
            this.btnCondiciones.Text = "Condiciones";
            this.btnCondiciones.UseVisualStyleBackColor = true;
            this.btnCondiciones.Click += new System.EventHandler(this.btnCondiciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCondiciones);
            this.Controls.Add(this.btnHabilidades);
            this.Controls.Add(this.btnConocimientos);
            this.Controls.Add(this.btnComplementos);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.btnFormacion);
            this.Controls.Add(this.btnFunciones);
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
        private System.Windows.Forms.Button btnFunciones;
        private System.Windows.Forms.Button btnFormacion;
        private System.Windows.Forms.Button btnExperiencia;
        private System.Windows.Forms.Button btnComplementos;
        private System.Windows.Forms.Button btnConocimientos;
        private System.Windows.Forms.Button btnHabilidades;
        private System.Windows.Forms.Button btnCondiciones;
    }
}

