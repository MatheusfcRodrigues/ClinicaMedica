namespace ClinicaWinForms
{
    public partial class Form1 : Form
    {
        private Clinica clinica = new Clinica();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarMedico(clinica);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarPaciente(clinica);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FormAgendarConsulta();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new FormListarConsultasPorMedico();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new FormHistoricoConsultasPorPaciente();
            form.ShowDialog();
        }
    }
}
