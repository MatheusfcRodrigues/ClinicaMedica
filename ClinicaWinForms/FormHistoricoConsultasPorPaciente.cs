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
    public partial class FormHistoricoConsultasPorPaciente : Form
    {
        private Clinica clinica; 
       
        public FormHistoricoConsultasPorPaciente()
        {
            InitializeComponent();
            this.clinica = clinica;

            CarregarPacientes();
        }

        private void CarregarPacientes()
        {
            cmbPacientes.DataSource = null;
            cmbPacientes.DataSource = clinica.Pacientes; // Certifique-se de que a propriedade Pacientes está acessível
            cmbPacientes.DisplayMember = "Nome"; // Exibe o nome do paciente no ComboBox
        }

        private void btnMostrarHistorico_Click(object sender, EventArgs e)
        {
            if (cmbPacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Paciente paciente = (Paciente)cmbPacientes.SelectedItem;
            var consultas = clinica.HistoricoPorPaciente(paciente);
            var dados = consultas.Select(c => new
            {
                DataHora = c.DataHora.ToString("dd/MM/yyyy HH:mm"),
                NomeMedico = c.Medico.Nome,
                EspecialidadeMedico = c.Medico.Especialidade
            }).ToList();
            dgvHistorico.DataSource = dados;
        }
    }
}
