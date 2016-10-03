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
using Dominio;
namespace UI
{
    public partial class frmAgregarCiudades : MaterialForm
    {
        ManejadorCiudades provincias = new ManejadorCiudades();
        public frmAgregarCiudades()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
            llenarCombo();
        }

        private void llenarCombo()
        {
            
            comboProvincias.DataSource = provincias.ListarProvincias();
            comboProvincias.DisplayMember = "Nombre";
            comboProvincias.ValueMember = "Cod_Provincia";
        }

        private void verificarCampos()
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (Controlador.SoloLetras(txtNombre.Text.Trim()) && Controlador.SoloNumeros(txtCodPostal.Text.Trim()) && txtCodPostal.Text != "")
            {
                //VERIFICAR QUE NO PASEN CAMPOS  VACIOS!
                Ciudade ciudades = new Ciudade();
                ciudades.Cod_Provincia = (byte)comboProvincias.SelectedValue;
                ciudades.Nombre = txtNombre.Text;
                ciudades.Cod_Postal = short.Parse((txtCodPostal.Text));
                if (provincias.agregarCiudad(ciudades))
                {
                    MessageBox.Show("La ciudad se agrego correctamente","Ciudades",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(txtCodPostal,"Este codigo postal ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Verificar los campos","Sistema");
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.EspaciosKeyPress(e,sender);
        }
    }
}
