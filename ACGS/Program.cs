
using BusinessLayer;
using DataAccessLayer;

namespace ACGS
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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(new RegisterUser(_Model));
        }
    }
}