using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pricingCDR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Al ejecutarse la aplicación corre este metodo
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;

            Application.Run(new Formularios.FrmMain());
        }
        
    }
}
