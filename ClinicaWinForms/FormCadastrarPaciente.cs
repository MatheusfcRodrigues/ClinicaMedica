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
                // 1. Coleta os dados do formulário
                var paciente = new Paciente
                {
                    Nome = txtNome.Text,
                    CPF = txtCPF.Text,
                    // Certifique-se que 'dptNascimento' é o nome correto do seu controle DateTimePicker
                    DataNascimento = dptNascimento.Value
                };

                // 2. Validação para campos obrigatórios (recomendado)
                if (string.IsNullOrWhiteSpace(paciente.Nome) || string.IsNullOrWhiteSpace(paciente.CPF))
                {
                    MessageBox.Show("Os campos Nome e CPF são obrigatórios.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. CORREÇÃO PRINCIPAL: Usa o PacienteDAL para salvar no banco de dados
                PacienteDAL pacienteDAL = new PacienteDAL();
                pacienteDAL.CadastrarPaciente(paciente);

                // 4. Feedback de sucesso para o usuário e fechamento do formulário
                MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                // O try-catch vai capturar erros do banco, como CPF duplicado
                MessageBox.Show("Erro ao cadastrar paciente. Verifique os dados e tente novamente.\n\nDetalhes: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
