namespace ClinicaWinForms
{
    partial class FormListarConsultasPorMedico
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
            this.cmbMedicos = new ComboBox();
            this.btnListar = new Button();
            this.dgvConsultas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new Point(20, 20);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new Size(300, 23);
            this.cmbMedicos.TabIndex = 0;
            this.cmbMedicos.Text = "Selecione o Médico";
            // 
            // btnListar
            // 
            this.btnListar.Location = new Point(330, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new Size(120, 30);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Consultas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new EventHandler(this.BtnListar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new Point(20, 70);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new Size(600, 300);
            this.dgvConsultas.TabIndex = 2;
            // 
            // FormListarConsultasPorMedico
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 400);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "FormListarConsultasPorMedico";
            this.Text = "Listar Consultas por Médico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMedicos;
        private Button btnListar;
        private DataGridView dgvConsultas;
    }
}
