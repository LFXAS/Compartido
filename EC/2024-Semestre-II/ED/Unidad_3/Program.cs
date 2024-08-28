using System;
using System.Windows.Forms;
using Unidad_3;

namespace Unidad_3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManejoArchivo1());
            //Application.Run(new ManejoArchivo2());
            //Application.Run(new ManejoArchivo3());
            Application.Run(new ManejoArchivo4());
        }
    }
}