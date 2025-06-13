using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaWinForms
{
    public partial class FormCadastrarMedico : Form
    {
        private Clinica clinica;

        public FormCadastrarMedico(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void FormCadastrarMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoMedico = new Medico
                {
                    Nome = txtNome.Text,
                    CRM = txtCRM.Text,
                    Especialidade = txtEspecialidade.Text
                };

                clinica.CadastrarMedico(novoMedico);
                MessageBox.Show("Médico cadastrado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
