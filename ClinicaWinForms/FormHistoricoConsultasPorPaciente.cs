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
                    Id = c.Id,
                    Hora = c.DataHora.ToString("dd/MM/yyyy HH:mm"),
                    Médico = c.Medico.Nome,
                    Especialidade = c.Medico.Especialidade
                }).ToList();

                //Só serve para escondar o ID do paciente
                if (dgvHistorico.Columns["Id"] != null)
                {
                    dgvHistorico.Columns["Id"].Visible = false;
                }

                // Use o nome correto do seu DataGridView
                dgvHistorico.DataSource = dados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o histórico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            // 1. Verifica se alguma linha da grade está selecionada
            if (dgvHistorico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione na grade a consulta que deseja cancelar.", "Seleção Necessária",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pede confirmação ao usuário (MUITO IMPORTANTE!)
            var resposta = MessageBox.Show("Tem certeza que deseja cancelar permanentemente esta consulta?", "Confirmar Cancelamento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    // 3. Obtém o ID da consulta da linha selecionada (da coluna invisível que criamos)
                    int consultaId = Convert.ToInt32(dgvHistorico.SelectedRows[0].Cells["Id"].Value);

                    // 4. Chama o método do DAL para deletar do banco de dados
                    ConsultaDAL consultaDAL = new ConsultaDAL();
                    consultaDAL.CancelarConsulta(consultaId);

                    MessageBox.Show("Consulta cancelada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Atualiza a grade para remover a consulta cancelada da exibição
                    // A forma mais fácil é chamar o evento de clique do botão de listar novamente.
                    btnMostrarHistorico_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao cancelar a consulta: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}