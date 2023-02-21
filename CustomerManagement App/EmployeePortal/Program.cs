using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeePortal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.CreateDirectory(Temp.FolderPath);
            Application.Run(new AuthentificationWindow());
            Application.Run(new MainWindow());
        }
    }
}
