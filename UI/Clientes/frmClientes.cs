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

namespace UI.Clientes
{
    public partial class frmClientes : MaterialForm
    {
        Controlador controlador = new Controlador();
        public frmClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            successProvider.Clear();
        }

        private void btnRefrescarCampos_Click(object sender, EventArgs e)
        {

        }

        //controlar que sean numeros.
        private void txtNumeroDocumento_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNumeroDocumento, "");
            successProvider.SetError(txtNumeroDocumento, "");
            if (txtNumeroDocumento.Text != "")
            {
                if (controlador.SoloNumeros(txtNumeroDocumento.Text) == false)
                {
                    errorProvider.SetError(txtNumeroDocumento, "Por favor ingrese un documento valido(solo numeros).");
                }
                else
                {
                    successProvider.SetError(txtNumeroDocumento, "Este formato es correcto.");
                }
            }
            else
            {
                errorProvider.SetError(txtNumeroDocumento, "Este campo es obligatorio.");
            }
           
        }

        //controlar que sea cadena de texto
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNombre, "");
            successProvider.SetError(txtNombre, "");

            if (txtNombre.Text !="")
            {
                if (controlador.SoloLetras(txtNombre.Text)== false)
                {
                    errorProvider.SetError(txtNombre,"Por favor ingrese un nombre valido(solo letras.)");
                }
                else
                {
                    successProvider.SetError(txtNombre,"El nombre es correcto.");
                }
            }
            else
            {
                errorProvider.SetError(txtNombre,"Este campo es obligatorio.");
            }
            
        }

  
    }
}
