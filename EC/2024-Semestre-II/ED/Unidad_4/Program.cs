using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrograma00());
            //Application.Run(new FrmPrograma01());
            Application.Run(new FrmPrograma02());
            //Application.Run(new FrmPrograma03());
            //Application.Run(new FrmPrograma04());
            //Application.Run(new UI.FrmEmpleado());
        }
    }
}
