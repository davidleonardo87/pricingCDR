using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ADOX;

namespace pricingCDR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Al ejecutarse la aplicación, se llama a este metodo
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;

            try
            {
                var obj = ConfigurationManager.AppSettings["basecreada"];
                bool basecreada = bool.Parse(obj);
                if (!basecreada)
                {
                    string fullFileName = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "cdrdb.accdb");
                    string cadenaConexion = string.Format("Provider=Microsoft.Ace.OleDB.12.0; Data source = {0}",fullFileName);
                    var cat = new Catalog();
                    cat.Create(cadenaConexion);
                    
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["ModelCDR"].ConnectionString = cadenaConexion;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                }
            }
            catch { }

            Application.Run(new Formularios.FrmMain());
        }
        
    }
}
