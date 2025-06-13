namespace ClinicaWinForms
{
    partial class FormAgendarConsulta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDataHora;

        private void InitializeComponent()
        {
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(30, 20);
            this.lblMedico.Text = "Médico:";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicos.Location = new System.Drawing.Point(100, 20);
            this.cmbMedicos.Size = new System.Drawing.Size(200, 23);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(30, 60);
            this.lblPaciente.Text = "Paciente:";
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.Location = new System.Drawing.Point(100, 60);
            this.cmbPacientes.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(30, 100);
            this.lblDataHora.Text = "Data e Hora:";
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHora.Location = new System.Drawing.Point(100, 100);
            this.dtpDataHora.Size = new System.Drawing.Size(200, 23);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(100, 140);
            this.btnAgendar.Size = new System.Drawing.Size(100, 30);
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // FormAgendarConsulta
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cmbPacientes);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.btnAgendar);
            this.Text = "Agendar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
