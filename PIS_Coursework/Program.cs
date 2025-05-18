using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using DataAccess;
using DataAccess.Models;

namespace PIS_Coursework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}