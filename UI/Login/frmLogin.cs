using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using
using MaterialSkin;
using MaterialSkin.Controls;
using LogicaDeNegocio;

namespace UI.Login
{
    public partial class frmLogin : MaterialForm
    {
        
        public frmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
            btnCerrar.BackColor = Color.FromArgb(249, 84, 107);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificarLogin()
        {
            var manejadorEmpleados = new ManejadorEmpleados();
            var login = manejadorEmpleados.VerificarLogin(txtUser.Text, txtPassword.Text);
            if (login != null)
            {
                this.DialogResult = DialogResult.OK;
                Sesion.nombre_apellido = login.Empleado.Apellido + " " + login.Empleado.Nombre;
                SesionCaja.importe_inicio = 0;
                Sesion.id_empleado = login.Nro_Empleado;
            }
            else
            {
                MessageBox.Show("Usuario o password incorrecta.", "Verifique sus datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerificarLogin();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VerificarLogin();
            }
        }
    }
}
