namespace WindowsFormsApp1
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboConsultas = new System.Windows.Forms.ComboBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chFiltro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConsultas
            // 
            this.cboConsultas.FormattingEnabled = true;
            this.cboConsultas.Items.AddRange(new object[] {
            "Consulta N° 1",
            "Consulta N° 2",
            "Consulta N° 3",
            "Consulta N° 4",
            "Consulta N° 5",
            "Consulta N° 6",
            "Consulta N° 7",
            "Consulta N° 8"});
            this.cboConsultas.Location = new System.Drawing.Point(139, 214);
            this.cboConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.cboConsultas.Name = "cboConsultas";
            this.cboConsultas.Size = new System.Drawing.Size(127, 21);
            this.cboConsultas.TabIndex = 0;
            this.cboConsultas.Text = "Seleccionar...";
            this.cboConsultas.SelectedIndexChanged += new System.EventHandler(this.cboConsultas_SelectedIndexChanged);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(67, 238);
            this.dgvConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(758, 145);
            this.dgvConsultas.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(760, 214);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(64, 19);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Enabled = false;
            this.rtxtDescripcion.Location = new System.Drawing.Point(67, 84);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(759, 63);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "";
            // 
            // dtp1
            // 
            this.dtp1.Enabled = false;
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(443, 214);
            this.dtp1.Margin = new System.Windows.Forms.Padding(2);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(83, 20);
            this.dtp1.TabIndex = 7;
            // 
            // dtp2
            // 
            this.dtp2.Enabled = false;
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(603, 214);
            this.dtp2.Margin = new System.Windows.Forms.Padding(2);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(84, 20);
            this.dtp2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha 2:";
            // 
            // chFiltro
            // 
            this.chFiltro.AutoSize = true;
            this.chFiltro.Enabled = false;
            this.chFiltro.Location = new System.Drawing.Point(698, 215);
            this.chFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.chFiltro.Name = "chFiltro";
            this.chFiltro.Size = new System.Drawing.Size(15, 14);
            this.chFiltro.TabIndex = 11;
            this.chFiltro.UseVisualStyleBackColor = true;
            this.chFiltro.CheckedChanged += new System.EventHandler(this.chFiltro_CheckedChanged);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 497);
            this.Controls.Add(this.chFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.cboConsultas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConsultas;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chFiltro;
    }
}

