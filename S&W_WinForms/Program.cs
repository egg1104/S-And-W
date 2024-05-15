using S_W.DB.Interfaces;
using S_W.DB.UOW;
using S_W_HealthStore.Models;


namespace S_W_WinForms
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DatabaseConnectionFactory dat = new DatabaseConnectionFactory();
            UnitOfWork unitOf = new UnitOfWork(dat);
            Application.Run(new S_W(unitOf));


        }
    }
}