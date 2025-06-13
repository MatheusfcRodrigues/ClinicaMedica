namespace ClinicaWinForms
{
    partial class FormHistoricoConsultasPorPaciente
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
            this.cmbPacientes = new ComboBox();
            this.btnMostrarHistorico = new Button();
            this.dgvHistorico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new Point(20, 20);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new Size(350, 23);
            this.cmbPacientes.TabIndex = 0;
            this.cmbPacientes.Text = "Selecione o Paciente";
            // 
            // btnMostrarHistorico
            // 
            this.btnMostrarHistorico.Location = new Point(380, 20);
            this.btnMostrarHistorico.Name = "btnMostrarHistorico";
            this.btnMostrarHistorico.Size = new Size(130, 30);
            this.btnMostrarHistorico.TabIndex = 1;
            this.btnMostrarHistorico.Text = "Mostrar Histórico";
            this.btnMostrarHistorico.UseVisualStyleBackColor = true;
            this.btnMostrarHistorico.Click += new EventHandler(this.btnMostrarHistorico_Click);
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new Point(20, 70);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new Size(630, 330);
            this.dgvHistorico.TabIndex = 2;
            // 
            // FormHistoricoConsultasPorPaciente
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(680, 420);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.btnMostrarHistorico);
            this.Controls.Add(this.cmbPacientes);
            this.Name = "FormHistoricoConsultasPorPaciente";
            this.Text = "Histórico de Consultas por Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPacientes;
        private Button btnMostrarHistorico;
        private DataGridView dgvHistorico;
    }
}
