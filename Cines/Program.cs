using CineApp;
using CineApp.Forms;
using CinesFront.Presentacion;
using CinesFront.Reportes;

namespace Cines
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmIniciarSesion());
            //Application.Run(new FrmButacasDisponiblies());
            Application.Run(new frmCliente());

        }
    }
}