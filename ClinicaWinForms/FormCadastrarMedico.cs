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
                // 1. Crie um objeto Medico com os dados preenchidos na tela.
                //    (SUBSTITUA 'txtNome', 'txtCrm', etc., pelos nomes reais dos seus campos de texto)
                var novoMedico = new Medico
                {
                    Nome = txtNome.Text,
                    CRM = txtCRM.Text,
                    Especialidade = txtEspecialidade.Text
                };

                // 2. Validação simples para não salvar dados em branco (Opcional, mas recomendado)
                if (string.IsNullOrWhiteSpace(novoMedico.Nome) || string.IsNullOrWhiteSpace(novoMedico.CRM))
                {
                    MessageBox.Show("Os campos Nome e CRM são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Use o MedicoDAL para salvar o novo médico no banco de dados.
                MedicoDAL medicoDAL = new MedicoDAL();
                medicoDAL.CadastrarMedico(novoMedico);

                // 4. Dê um feedback de sucesso para o usuário e feche a tela de cadastro.
                MessageBox.Show("Médico cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o formulário atual
            }
            catch (Exception ex)
            {
                // O bloco try-catch é MUITO importante aqui. Ele vai capturar erros do banco,
                // como tentar cadastrar um CRM que já existe (por causa da restrição UNIQUE na tabela).
                MessageBox.Show("Erro ao cadastrar médico. Verifique os dados e tente novamente.\n\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
