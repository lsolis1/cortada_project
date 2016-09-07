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
using LogicaDeNegocio;
using System.Globalization;

namespace UI.MainMenu
{
    public partial class frmModificarDinero : MaterialForm
    {
        public frmModificarDinero()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
            txtAgregarDinero.MaxLength = 7;
        }

        public void ModificarDinero(string monto)
        {
            errorProvider.Clear();
            decimal monto_modificar;
            var cultureInfo = new System.Globalization.CultureInfo("es-AR");
            var importe_inicio = decimal.TryParse(monto, NumberStyles.Currency, cultureInfo, out monto_modificar);
            if (txtAgregarDinero.Text !="")
            {
                if (radioAgregar.Checked && importe_inicio==true)
                {
                    decimal importe_temporal = SesionCaja.importe_actual + Math.Abs(monto_modificar);
                    if(MessageBox.Show("Se agregara $"+monto_modificar.ToString()+ Environment.NewLine +"Su total sera de: "+importe_temporal.ToString(),"¿Esta seguro?",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        SesionCaja.importe_actual += Math.Abs(monto_modificar);
                        this.Close();
                    }
                    else
                    {
                        radioAgregar.Checked = false;
                        txtAgregarDinero.Text = "";
                    }

                }
                else if (radioQuitar.Checked && importe_inicio==true)
                {
                    
                    if (SesionCaja.importe_actual - monto_modificar <= 0)
                    {
                        errorProvider.SetError(txtAgregarDinero, "El numero ingresado es igual o mayor al de la caja.");
                    }
                    else
                    {
                        decimal importe_temporal = SesionCaja.importe_actual - Math.Abs(monto_modificar);
                        if(MessageBox.Show("Se quitaran $" + monto_modificar.ToString() + Environment.NewLine + "Su total sera de: " + importe_temporal, "¿Esta seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            SesionCaja.importe_actual -= Math.Abs(monto_modificar);
                            this.Close();
                        }
                        else
                        {
                            radioQuitar.Checked = false;
                            txtAgregarDinero.Text = "";
                        }
                        
                    }
                }
                else
                {
                    errorProvider.SetError(groupBox1,"Por favor selecciones una opcion");
                }

            }
            else
            {
                errorProvider.SetError(txtAgregarDinero,"Por favor escriba un monto");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModificarDinero(txtAgregarDinero.Text);
        }

        private void txtAgregarDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }*/
        }
    }
}
