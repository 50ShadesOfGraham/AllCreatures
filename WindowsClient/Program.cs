using BusinessLayer;
using DataAccessLayer;
using System.Diagnostics;

namespace WindowsClient
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDataLayer _Datalayer = DataLayer.GetInstance();  // DataLayer object is a singleton, only 1 instance allowed. With Songleton pattern use GetInstance() method to create it.
            IModel _Model = Model.GetInstance(_Datalayer);
             //Test Debug
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserIndex(_Model));
            //Process.GetCurrentProcess().Kill();
            //System.Diagnostics.Process.Start("WindowsClient.exe", "/c taskkill /IM WindowsClient.exe");
           //System.Windows.Forms.Application.Exit();


            }
    }
}