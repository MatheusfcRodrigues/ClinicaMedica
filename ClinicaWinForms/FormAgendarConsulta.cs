using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Adicione o namespace do seu projeto, se for diferente
namespace ClinicaWinForms
{
    public partial class FormAgendarConsulta : Form
    {
        // 1. REMOVEMOS a variável 'private Clinica clinica;'
        // O formulário não precisa mais dela.

        // 2. O construtor agora não recebe mais a 'Clinica' e chama os novos métodos de carregamento.
        public FormAgendarConsulta()
        {
            InitializeComponent();
            CarregarMedicos();
            CarregarPacientes();
        }

        // 3. NOVO MÉTODO: Carrega os médicos do banco de dados.
        private void CarregarMedicos()
        {
            try
            {
                MedicoDAL medicoDAL = new MedicoDAL();
                List<Medico> medicos = medicoDAL.ListarMedicos();
                cmbMedicos.DataSource = medicos;
                cmbMedicos.DisplayMember = "Nome";
                cmbMedicos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar médicos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. NOVO MÉTODO: Carrega os pacientes do banco de dados.
        private void CarregarPacientes()
        {
            try
            {
                PacienteDAL pacienteDAL = new PacienteDAL();
                List<Paciente> pacientes = pacienteDAL.ListarPacientes();
                cmbPacientes.DataSource = pacientes;
                cmbPacientes.DisplayMember = "Nome";
                cmbPacientes.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pacientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. MÉTODO ATUALIZADO: Salva a consulta usando o ConsultaDAL.
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedItem == null || cmbPacientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um médico e um paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var medicoSelecionado = (Medico)cmbMedicos.SelectedItem;
                var pacienteSelecionado = (Paciente)cmbPacientes.SelectedItem;
                var dataHoraSelecionada = dtpDataHora.Value;

                var novaConsulta = new Consulta
                {
                    DataHora = dataHoraSelecionada,
                    MedicoId = medicoSelecionado.Id,
                    PacienteId = pacienteSelecionado.Id
                };

                ConsultaDAL consultaDAL = new ConsultaDAL();
                consultaDAL.AgendarConsulta(novaConsulta);

                MessageBox.Show("Consulta agendada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}