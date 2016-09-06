using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MaterialSkin;
using MaterialSkin.Controls;
using Dominio;
using LogicaDeNegocio;

namespace UI.MainMenu
{
    public partial class frmModificarDinero : MaterialForm
    {
        //private ManejadorCaja manejadorCaja = new ManejadorCaja()
        ManejadorCaja manejadorCaja = new ManejadorCaja();
        public frmModificarDinero()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
            txtAgregarDinero.MaxLength = 7;
        }

        public void AgregarDinero(string monto)
        {
            

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAgregarDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
