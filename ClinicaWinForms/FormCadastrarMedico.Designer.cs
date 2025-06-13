namespace ClinicaWinForms
{
    partial class FormCadastrarMedico
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblEspecialidade;

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtCRM = new TextBox();
            txtEspecialidade = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblCRM = new Label();
            lblEspecialidade = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 0;
            // 
            // txtCRM
            // 
            txtCRM.Location = new Point(100, 60);
            txtCRM.Name = "txtCRM";
            txtCRM.Size = new Size(200, 27);
            txtCRM.TabIndex = 1;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(138, 96);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(200, 27);
            txtEspecialidade.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(127, 158);
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
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCRM
            // 
            lblCRM.AutoSize = true;
            lblCRM.Location = new Point(30, 60);
            lblCRM.Name = "lblCRM";
            lblCRM.Size = new Size(43, 20);
            lblCRM.TabIndex = 1;
            lblCRM.Text = "CRM:";
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(28, 99);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(104, 20);
            lblEspecialidade.TabIndex = 2;
            lblEspecialidade.Text = "Especialidade:";
            // 
            // FormCadastrarMedico
            // 
            ClientSize = new Size(350, 200);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCRM);
            Controls.Add(txtCRM);
            Controls.Add(lblEspecialidade);
            Controls.Add(txtEspecialidade);
            Controls.Add(btnSalvar);
            Name = "FormCadastrarMedico";
            Text = "Cadastro de Médico";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
