using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using UI.Login;

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
                //mandamos el apellido y documento al main form.
                Application.Run(new frmMainMenu(nuevoLogin.getDocumento,nuevoLogin.getApellido));
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
