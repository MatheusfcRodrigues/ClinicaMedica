using Clínica_Médica;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class FormAgendarConsulta : Form
{
    private Clinica clinica;

    public FormAgendarConsulta(Clinica clinica)
    {
        InitializeComponent();
        this.clinica = clinica;

        CarregarDados();
    }

    private void CarregarDados()
    {
        cmbMedicos.DataSource = clinica.Medicos;
        cmbMedicos.DisplayMember = "Nome";

        cmbPacientes.DataSource = clinica.Pacientes;
        cmbPacientes.DisplayMember = "Nome";
    }

    private void btnAgendar_Click(object sender, EventArgs e)
    {
        try
        {
            var medico = (Medico)cmbMedicos.SelectedItem;
            var paciente = (Paciente)cmbPacientes.SelectedItem;
            var dataHora = dtpDataHora.Value;

            clinica.AgendarConsulta(medico, paciente, dataHora);
            MessageBox.Show("Consulta agendada!");
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }
}
