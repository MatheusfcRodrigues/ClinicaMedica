using Clínica_Médica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaWinForms
{
    public partial class FormListarConsultasPorMedico : Form
    {
        private Clinica clinica;

        public FormListarConsultasPorMedico()
        {
            InitializeComponent();
            this.clinica = clinica; // Assumindo que você tem uma instância única da Clinica

            CarregarMedicos();
        }

        private void CarregarMedicos()
        {
            cmbMedicos.DataSource = null;
            cmbMedicos.DataSource = clinica.Medicos; // Certifique-se de que a propriedade Medicos está acessível
            cmbMedicos.DisplayMember = "Nome"; // Exibe o nome do médico no ComboBox
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medico medico = (Medico)cmbMedicos.SelectedItem;
            List<Consulta> consultas = clinica.ConsultasPorMedico(medico);

            var dados = consultas.Select(c => new
            {
                DataHora = c.DataHora.ToString("dd/MM/yyyy HH:mm"),
                NomePaciente = c.Paciente.Nome
            }).ToList();

            dgvConsultas.DataSource = dados;
        }
    }
}
