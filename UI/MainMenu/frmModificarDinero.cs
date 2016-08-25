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
            if (monto != "")
            {

                if (radioAgregar.Checked == true)
                {
                    try
                    {
                        var casteoMonto = decimal.Parse(monto);
                        if (manejadorCaja.AgregarDineroCaja(casteoMonto))
                        {
                            MessageBox.Show("El saldo en caja se actualizo correctamente", "La cortada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Al parecer no se encontro la caja", "La cortada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Por favor ingrese un formato correcto");
                    }
                }
                else if (radioQuitar.Checked == true)
                {
                    try
                    {
                        var castearMonto = decimal.Parse(monto);
                        if (manejadorCaja.QuitarDineroCaja(castearMonto))
                        {
                            MessageBox.Show("El saldo en caja se actualizo correctamente", "La cortada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El monto ingresado es mayor o igual al de la caja!", "La cortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Por favor ingrese un formato correcto");
                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor", "La cortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarDinero(txtAgregarDinero.Text.Trim());
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
