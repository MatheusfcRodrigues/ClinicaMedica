namespace ClinicaWinForms
{
    partial class FormCadastrarPaciente
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DateTimePicker dptNascimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento;

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtCPF = new TextBox();
            dptNascimento = new DateTimePicker();
            btnSalvar = new Button();
            lblNome = new Label();
            lblCPF = new Label();
            lblNascimento = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(100, 60);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 23);
            txtCPF.TabIndex = 1;
            // 
            // dptNascimento
            // 
            dptNascimento.CustomFormat = "dd/MM/yyyy";
            dptNascimento.Format = DateTimePickerFormat.Custom;
            dptNascimento.Location = new Point(170, 110);
            dptNascimento.Name = "dptNascimento";
            dptNascimento.Size = new Size(200, 23);
            dptNascimento.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(100, 160);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(30, 60);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF:";
            // 
            // lblNascimento
            // 
            lblNascimento.AutoSize = true;
            lblNascimento.Location = new Point(30, 115);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(117, 15);
            lblNascimento.TabIndex = 2;
            lblNascimento.Text = "Data de Nascimento:";
            // 
            // FormCadastrarPaciente
            // 
            ClientSize = new Size(386, 200);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(lblNascimento);
            Controls.Add(dptNascimento);
            Controls.Add(btnSalvar);
            Name = "FormCadastrarPaciente";
            Text = "Cadastro de Paciente";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

