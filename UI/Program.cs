using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Login;
using LogicaDeNegocio;

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
            //Application.Run(new frmMainMenu());
            //Application.Run(new frmLogin());

            frmLogin nuevoLogin = new frmLogin();
            if (nuevoLogin.ShowDialog()==DialogResult.OK)
            {
                //obtenemos el nombre,apellido y lo mandamos al main
                ManejadorEmpleados manejador_empleado = new ManejadorEmpleados();
                
                Application.Run(new frmMainMenu(manejador_empleado.ObtenerNombreApellido(nuevoLogin.getUsuario,nuevoLogin.getPassword)));
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
