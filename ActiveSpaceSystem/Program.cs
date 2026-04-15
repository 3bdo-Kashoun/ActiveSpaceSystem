using ActiveSpaceSystem.Forms.MainForms;
using ActiveSpaceSystem.Forms.SideForms;
namespace ActiveSpaceSystem
{
    internal static class Program
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
<<<<<<< HEAD
            Application.Run(new MainForm());
=======
            Application.Run(new ReportsForm());
>>>>>>> d018423b691729f2161df65cb074659267570a6c
            //Application.Run(new Dashboard());
        }
    }
}