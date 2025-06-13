// using Clínica_Médica; // Não precisamos mais deste, a menos que as classes Medico/Paciente estejam nele
using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Substitua "ClinicaWinForms" pelo namespace real do seu projeto, se for diferente
namespace ClinicaWinForms
{
    public partial class FormListarConsultasPorMedico : Form
    {
        // REMOVEMOS a variável 'private Clinica clinica;'
        // O formulário não precisa mais saber sobre a classe 'Clinica'.

        public FormListarConsultasPorMedico()
        {
            InitializeComponent();
            // REMOVEMOS a linha 'this.clinica = Program.ClinicaInstance;'

            // A chamada para carregar os médicos continua aqui.
            CarregarMedicos();
        }

        // MÉTODO CORRIGIDO
        private void CarregarMedicos()
        {
            try
            {
                // Este método agora usa MedicoDAL para buscar os médicos do banco de dados SQL.
                MedicoDAL medicoDAL = new MedicoDAL();
                List<Medico> medicosDoBanco = medicoDAL.ListarMedicos();

                // Configura o ComboBox para exibir os médicos
                cmbMedicos.DataSource = null;
                cmbMedicos.DataSource = medicosDoBanco;
                cmbMedicos.DisplayMember = "Nome";
                cmbMedicos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os médicos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SEU MÉTODO DE CLICK JÁ ESTAVA CORRETO E FOI MANTIDO
        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Medico medicoSelecionado = (Medico)cmbMedicos.SelectedItem;
                ConsultaDAL consultaDAL = new ConsultaDAL();
                List<Consulta> consultas = consultaDAL.ListarConsultasPorMedico(medicoSelecionado.Id);

                var dadosParaExibir = consultas.Select(c => new
                {
                    DataHora = c.DataHora.ToString("dd/MM/yyyy HH:mm"),
                    NomePaciente = c.Paciente.Nome
                }).ToList();

                dgvConsultas.DataSource = null;
                dgvConsultas.DataSource = dadosParaExibir;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar as consultas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}