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
using Dominio;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var manejadorEmpleados = new ManejadorEmpleados();
            if (manejadorEmpleados.VerificarLogin(txtUser.Text, txtPassword.Text) == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o password incorrecta.", "Verifique sus datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        public string getApellido {
            get
            {
                return txtUser.Text;
            }
            
        }

        public string getDocumento {
            get
            {
                return txtPassword.Text;
            }
         }


    }
}
