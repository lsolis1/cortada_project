using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Login;
using LogicaDeNegocio;
using UI.MainMenu;

namespace UI
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

            frmLogin nuevoLogin = new frmLogin();
            if (nuevoLogin.ShowDialog() == DialogResult.OK)
            {
                //obtenemos el nombre,apellido y lo mandamos al main
                frmImporteInicio frmImporteInicio = new frmImporteInicio();
                if (frmImporteInicio.ShowDialog() == DialogResult.OK)
                {
                    ManejadorEmpleados manejador_empleado = new ManejadorEmpleados();

                    Application.Run(new frmMainMenu());

                }

            }
            else
            {
                Application.Exit();
            }

        }
    }
}
