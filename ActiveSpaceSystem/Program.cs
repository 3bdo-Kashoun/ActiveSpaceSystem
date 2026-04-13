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
            Application.Run(new MonthlyContractForm());
=======
            Application.Run(new Dashboard());
>>>>>>> 9f9a062009b46bc572291917b07b4551cdbd9c3f
        }
    }
}