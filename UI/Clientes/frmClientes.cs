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

        private void refrescarCamposRegistrarTab()
        {
            txtNumeroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDomicilio.Text = "";
            txtCelular.Text = "";
            txtCodigoPostal.Text = "";
            txtMail.Text = "";
        }

        //boton en registrarTAB
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text !="" && controlador.SoloNumeros(txtNumeroDocumento.Text)==true && txtNombre.Text !="" && controlador.SoloLetras(txtNombre.Text)==true && txtApellido.Text !="" && controlador.SoloLetras(txtApellido.Text)==true && txtDomicilio.Text !="" && controlador.SoloLetrasYnumeros(txtDomicilio.Text) == true && txtCelular.Text!="" && controlador.SoloNumeros(txtCelular.Text)==true && txtCodigoPostal.Text!="" && controlador.SoloNumeros(txtCodigoPostal.Text)==true)
            {
                errorProvider.Clear();
                successProvider.Clear();
                //agregar los datos a la base de datos....
            }
            else
            {
                MessageBox.Show("Usted tiene un error, por favor revise los campos.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        //boton en registrarTAB
        private void btnRefrescarCampos_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            successProvider.Clear();
            refrescarCamposRegistrarTab();
        }

        //En el texto error 1 debera ir el texto dependiendo el caso. Por ejemplo: si es solo numeros, se debera ingresar el texto en caso de que se
        //encuentre 1 valor que no sea numero.
        //En nombreFuncion debera ir el nombre de la funcion que querramos ejecutar de la clase Controlador.
        private void ComprobarCampos(MaterialSingleLineTextField _control, string nombreFuncion, string textoError1)
        {
            if (_control.Text !="")
            {
                switch (nombreFuncion)
                {
                    case "SoloNumeros":
                        if (controlador.SoloNumeros(_control.Text)==false)
                        {
                            errorProvider.SetError(_control, textoError1);
                        }
                        else
                        {
                            successProvider.SetError(_control, "Este campo es correcto.");
                        }
                        break;

                    case "SoloLetras":
                        if (controlador.SoloLetras(_control.Text)==false)
                        {
                            errorProvider.SetError(_control,textoError1);
                        }
                        else
                        {
                            successProvider.SetError(_control,"Este campo es correcto");
                        }
                        break;
                }
            }
            else
            {
                errorProvider.SetError(_control, "Este campo es obligatorio");
            }
            

        }

        //controlar que sean numeros.
        private void txtNumeroDocumento_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNumeroDocumento, "");
            successProvider.SetError(txtNumeroDocumento, "");
            ComprobarCampos(txtNumeroDocumento, "SoloNumeros", "Por favor ingrese un documento valido(solo se admiten numeros).");
           
        }

        //controlar que sea cadena de texto
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNombre, "");
            successProvider.SetError(txtNombre, "");
            ComprobarCampos(txtNombre,"SoloLetras","Por favor ingrese un nombre  valido(no se admiten numeros)");
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            refrescarCamposRegistrarTab();
            errorProvider.Clear();
            successProvider.Clear();
        }
    }
}
