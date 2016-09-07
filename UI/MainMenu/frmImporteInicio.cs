using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;
using LogicaDeNegocio;
using System.Globalization;

namespace UI.MainMenu
{
    public partial class frmImporteInicio : MaterialForm
    {
        public frmImporteInicio()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
        }
        
        private bool VerificarMonto(string importe_inicio,string repetir_monto)
        {
            errorProvider.Clear();
            //hacer validaciones.
            if (importe_inicio != "" && repetir_monto != null)
            {
                if (importe_inicio==repetir_monto)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (VerificarMonto(txtMontoInicio.Text,txtRepetirMonto.Text))
            {
                decimal monto;
                var cultureInfo = new System.Globalization.CultureInfo("es-AR");
                var importe_inicio = decimal.TryParse(txtMontoInicio.Text,NumberStyles.Currency,cultureInfo, out monto);
                if (importe_inicio)
                {
                    SesionCaja.importe_actual = Math.Abs(monto);
                    SesionCaja.importe_inicio = Math.Abs(monto);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider.SetError(lblDinero,"El monto ingresado es incorrecto,ingrese un formato correcto.");
                }
                
            }
            else
            {
                errorProvider.SetError(lblDinero,"Los campos no coinciden o no hay ningun valor en uno de los campos");
            }
        }


    }

}
