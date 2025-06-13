// Em Program.cs
namespace ClinicaWinForms
{
    internal static class Program
    {
        // A inst�ncia � criada aqui, mas suas listas internas est�o VAZIAS.
        public static Clinica ClinicaInstance = new Clinica();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            // Form1 � o seu menu principal
            Application.Run(new Form1());
        }
    }
}