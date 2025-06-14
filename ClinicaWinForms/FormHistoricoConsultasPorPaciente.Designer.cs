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
            cmbPacientes = new ComboBox();
            btnMostrarHistorico = new Button();
            dgvHistorico = new DataGridView();
            btnCancelarConsulta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(23, 27);
            cmbPacientes.Margin = new Padding(3, 4, 3, 4);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(399, 28);
            cmbPacientes.TabIndex = 0;
            cmbPacientes.Text = "Selecione o Paciente";
            // 
            // btnMostrarHistorico
            // 
            btnMostrarHistorico.Location = new Point(455, 27);
            btnMostrarHistorico.Margin = new Padding(3, 4, 3, 4);
            btnMostrarHistorico.Name = "btnMostrarHistorico";
            btnMostrarHistorico.Size = new Size(149, 28);
            btnMostrarHistorico.TabIndex = 1;
            btnMostrarHistorico.Text = "Mostrar Histórico";
            btnMostrarHistorico.UseVisualStyleBackColor = true;
            btnMostrarHistorico.Click += btnMostrarHistorico_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(23, 93);
            dgvHistorico.Margin = new Padding(3, 4, 3, 4);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.Size = new Size(720, 265);
            dgvHistorico.TabIndex = 2;
            // 
            // btnCancelarConsulta
            // 
            btnCancelarConsulta.Location = new Point(23, 440);
            btnCancelarConsulta.Name = "btnCancelarConsulta";
            btnCancelarConsulta.Size = new Size(178, 47);
            btnCancelarConsulta.TabIndex = 3;
            btnCancelarConsulta.Text = "Cancelar Consulta";
            btnCancelarConsulta.UseVisualStyleBackColor = true;
            btnCancelarConsulta.Click += btnCancelarConsulta_Click;
            // 
            // FormHistoricoConsultasPorPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 560);
            Controls.Add(btnCancelarConsulta);
            Controls.Add(dgvHistorico);
            Controls.Add(btnMostrarHistorico);
            Controls.Add(cmbPacientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHistoricoConsultasPorPaciente";
            Text = "Histórico de Consultas por Paciente";
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPacientes;
        private Button btnMostrarHistorico;
        private DataGridView dgvHistorico;
        private Button btnCancelarConsulta;
    }
}
