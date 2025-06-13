// using Clínica_Médica; // Não é mais necessário, a menos que as classes de modelo estejam nele
using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Substitua "ClinicaWinForms" pelo namespace real do seu projeto, se for diferente
namespace ClinicaWinForms
{
    public partial class FormHistoricoConsultasPorPaciente : Form
    {
        // REMOVEMOS a variável 'private Clinica clinica;'

        public FormHistoricoConsultasPorPaciente()
        {
            InitializeComponent();
            // REMOVEMOS a linha 'this.clinica = Program.ClinicaInstance;'

            CarregarPacientes();
        }

        // MÉTODO CORRIGIDO
        private void CarregarPacientes()
        {
            try
            {
                // Este método agora usa PacienteDAL para buscar os pacientes do banco de dados SQL.
                PacienteDAL pacienteDAL = new PacienteDAL();
                List<Paciente> pacientesDoBanco = pacienteDAL.ListarPacientes();

                // Configura o ComboBox para exibir os pacientes
                cmbPacientes.DataSource = null;
                cmbPacientes.DataSource = pacientesDoBanco;
                cmbPacientes.DisplayMember = "Nome";
                cmbPacientes.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os pacientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SEU MÉTODO DE CLICK JÁ ESTAVA CORRETO E FOI MANTIDO
        private void btnMostrarHistorico_Click(object sender, EventArgs e)
        {
            if (cmbPacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Pega o objeto Paciente completo que foi selecionado
                Paciente paciente = (Paciente)cmbPacientes.SelectedItem;

                // CRIA A INSTÂNCIA DO DAL E BUSCA OS DADOS DO BANCO
                ConsultaDAL consultaDAL = new ConsultaDAL();
                var consultas = consultaDAL.ListarConsultasPorPaciente(paciente.Id);

                // O resto do seu código para formatar os dados continua igual e agora vai funcionar!
                var dados = consultas.Select(c => new
                {
                    Hora = c.DataHora.ToString("dd/MM/yyyy HH:mm"),
                    Médico = c.Medico.Nome,
                    Especialidade = c.Medico.Especialidade
                }).ToList();

                // Use o nome correto do seu DataGridView
                dgvHistorico.DataSource = dados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o histórico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}