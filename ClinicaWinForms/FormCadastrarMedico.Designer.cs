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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 20);
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(30, 60);
            this.lblCRM.Text = "CRM:";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(100, 60);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(200, 23);
            this.txtCRM.TabIndex = 1;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(30, 100);
            this.lblEspecialidade.Text = "Especialidade:";
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(115, 100);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(200, 23);
            this.txtEspecialidade.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(100, 140);
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastrarMedico
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.btnSalvar);
            this.Text = "Cadastro de Médico";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
