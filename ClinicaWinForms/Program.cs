// Em Program.cs
namespace ClinicaWinForms
{
    internal static class Program
    {
        // A instância é criada aqui, mas suas listas internas estão VAZIAS.
        public static Clinica ClinicaInstance = new Clinica();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            // Form1 é o seu menu principal
            Application.Run(new Form1());
        }
    }
}