using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Simulafdor_de_Memoria_RAM
{
    internal static class Program
    {
        private static Form1 form = new Form1();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //Crear instancia de generador de Proceso

        }
    }
}