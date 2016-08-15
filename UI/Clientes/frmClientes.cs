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

            CargarComboTipoDNI();
            
        }
        #region Registrar Tab
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
                //agregar los datos a la base de datos....

                txtNombre.Text.Trim(); //Trim quita los espacios al comienzo y  final de un string.
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
            refrescarCamposRegistrarTab();
        }

        
        //verificar si los texbox estan nulos
        private void emptyOrnull(bool _funcionControladora,MaterialSingleLineTextField _txtBox)
        {
            if (_funcionControladora==false)
            {
                errorProvider.SetError(_txtBox,"Este campo esta vacio");
            }

        }

        //controlar que sea cadena de texto
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNombre, "");
            ComprobarCampos(txtNombre,"SoloLetras","Por favor ingrese un nombre  valido(no se admiten numeros)");
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtApellido, "");
            ComprobarCampos(txtApellido,"SoloLetras","Ingrese un apellido valido(solo letras)");
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDomicilio, "");
            ComprobarCampos(txtDomicilio, "SoloLetrasYnumeros", "Ingrese una direccion valida");
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCelular, "");
            ComprobarCampos(txtCelular,"SoloNumeros","Ingrese un celular valido.");
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            refrescarCamposRegistrarTab();
            errorProvider.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.EspaciosKeyPress(e,sender);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.EspaciosKeyPress(e, sender);
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlador.EspaciosKeyPress(e,sender);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion Fin RegistrarTab


        #region Funciones_Registrar_Tab

        private void CargarComboTipoDNI()
        {
            //Cargamos los combos de tipo DNI de la pestaña Registrar
            cmbTipoDocumento.DataSource = new ManejadorDNI().ListarDocumentos();
            cmbTipoDocumento.DisplayMember = "Descripcion";
            cmbTipoDocumento.ValueMember = "Tipo_Doc";
        }




        #endregion Fin_Funciones_Registrar_Tab


        //En el texto error 1 debera ir el texto dependiendo el caso. Por ejemplo: si es solo numeros, se debera ingresar el texto en caso de que se
        //encuentre 1 valor que no sea numero.
        //En nombreFuncion debera ir el nombre de la funcion que querramos ejecutar de la clase Controlador.
        private void ComprobarCampos(MaterialSingleLineTextField _control, string nombreFuncion, string textoError1)
        {
            if (!string.IsNullOrWhiteSpace(_control.Text))
            {
                switch (nombreFuncion)
                {
                    case "SoloNumeros":
                        if (controlador.SoloNumeros(_control.Text) == false)
                        {
                            errorProvider.SetError(_control, textoError1);
                        }
                        break;

                    case "SoloLetras":
                        if (controlador.SoloLetras(_control.Text) == false)
                        {
                            errorProvider.SetError(_control, textoError1);
                        }
                        break;
                    case "SoloLetrasYnumeros":
                        if (controlador.SoloLetrasYnumeros(_control.Text) == false)
                        {
                            errorProvider.SetError(_control, textoError1);
                        }
                        break;
                }
            }
            else
            {
                errorProvider.SetError(_control, "Campo vacio.");
            }
        }


    }
}
