using WinFormsApps.Program002;

namespace WinFormsApps
{
    public static class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Program002.FormPrincipal());
        }
    }
}