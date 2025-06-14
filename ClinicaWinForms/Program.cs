namespace ClinicaWinForms
{
    internal static class Program
    {
        public static Clinica ClinicaInstance = new Clinica();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}