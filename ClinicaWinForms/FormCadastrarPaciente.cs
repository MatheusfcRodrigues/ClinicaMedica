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
    public partial class FormCadastrarPaciente : Form
    {
        private Clinica clinica;

        public FormCadastrarPaciente(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new Paciente
                {
                    Nome = txtNome.Text,
                    CPF = txtCPF.Text,
                    DataNascimento = dptNascimento.Value
                };

                clinica.CadastrarPaciente(paciente);
                MessageBox.Show($"Pacientes cadastrado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
