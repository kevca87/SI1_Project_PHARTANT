using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARTANT.Global;
using PHARTANT.UI;

namespace PHARTANT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetGlobalData();
            Application.Run(new MainForm());
        }
        static void SetGlobalData()
        {
            //GlobalData.connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Marcos\UCB\progs\BD\Vuelos.accdb";
            GlobalData.connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\kevca\Documents\UNIVERSIDAD\4to Semestre\Sistemas_de_Informacion\Proyecto_Final\SI1_Project_PHARTANT\PHARTANT\datosFarmaPlus1.mdb; Persist Security Info = True";
        }
    }
}
