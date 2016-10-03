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
using Dominio;
namespace UI.Administrador
{
    public partial class frmEmpleado : MaterialForm
    {
        ManejadorEmpleados manejador_empleado = new ManejadorEmpleados();
        ManejadorCiudades manejadorCiudades = new ManejadorCiudades();
        Empleado empleado;
        Empleado empleado_actual;
        public frmEmpleado()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);
            //llenar combos
            LlenarComboTipoDni();
            listarComboProvincias();
            //ciudad por defecto
            comboCiudades.SelectedIndex = 1;
            btnAgregar.Visible = true;
            btnGuardarCambios.Visible = false;
            checkAlta.Visible = false;
        }

        #region Editar datos empleado
        public frmEmpleado(Empleado empleado)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

            this.empleado_actual = empleado;

            LlenarComboTipoDni();
            listarComboProvincias();
            listarComboCiudades();
            CargarDatosEmpleado();

            btnAgregar.Visible = false;
            btnGuardarCambios.Visible = true;
            checkAlta.Visible = true;
            if (empleado_actual.Fecha_Baja == null)
            {
                checkAlta.Enabled = false;
            }
        }

        private void CargarDatosEmpleado()
        {
            comboTipoDoc.SelectedValue = empleado_actual.Tipo_Doc;
            txtNroDocumento.Text = empleado_actual.Nro_Doc.ToString();
            txtNombre.Text = empleado_actual.Nombre;
            txtApellido.Text = empleado_actual.Apellido;
            txtTelefono.Text = empleado_actual.Telefono;
            txtCelular.Text = empleado_actual.Celular;
            txtDomicilio.Text = empleado_actual.Domicilio;
            comboProvincias.SelectedValue = empleado_actual.Ciudade.Cod_Provincia;
            comboCiudades.SelectedValue = empleado_actual.Cod_Postal;
            txtMail.Text = empleado_actual.Mail;
            txtUsuario.Text = manejador_empleado.ObtenerDatosLogin(empleado_actual).username;
            txtPassword.Text = manejador_empleado.ObtenerDatosLogin(empleado_actual).password;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (VerificarCampos(txtNroDocumento.Text, txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("Algun campo obligatorio esta vacio", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ModificarEmpleado();
                if (manejador_empleado.ModificarEmpleado(empleado_actual))
                {
                    MessageBox.Show("Empleado "+empleado_actual.Nombre+" "+empleado_actual.Apellido+" modificado correctamente","modificacion correcta",MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void ModificarEmpleado()
        {
            try
            {
                empleado_actual.Nombre = txtNombre.Text;
                empleado_actual.Apellido = txtApellido.Text;
                empleado_actual.Tipo_Doc = (byte)comboTipoDoc.SelectedValue;
                empleado_actual.Nro_Doc = Convert.ToInt64(txtNroDocumento.Text);
                empleado_actual.Mail = txtMail.Text;
                empleado_actual.Telefono = txtTelefono.Text;
                empleado_actual.Celular = txtCelular.Text;
                empleado_actual.Domicilio = txtDomicilio.Text;
                empleado_actual.Cod_Postal = (short)comboCiudades.SelectedValue;
                if (checkAlta.Checked)
                {
                    empleado_actual.Fecha_Baja = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el empleado...");
                throw;
            }
           
        }
        #endregion
        private void LlenarComboTipoDni()
        {
            comboTipoDoc.DataSource = TipoDocSesion.getSetTipoDoc;
            comboTipoDoc.DisplayMember = "Descripcion";
            comboTipoDoc.ValueMember = "Tipo_Doc";
        }

        #region Agregar empleado


        private void listarComboProvincias()
        {
            comboProvincias.DataSource = manejadorCiudades.ListarProvincias();
            comboProvincias.DisplayMember = "Nombre";
            comboProvincias.ValueMember = "Cod_Provincia";
        }
        private void listarComboCiudades()
        {
            byte provincia;
            bool parseOK = byte.TryParse(comboProvincias.SelectedValue.ToString(), out provincia);
            if (parseOK)
            {
                comboCiudades.DataSource = manejadorCiudades.ListarCiudades(Convert.ToByte(comboProvincias.SelectedValue));
                comboCiudades.DisplayMember = "Nombre";
                comboCiudades.ValueMember = "Cod_Postal";
            }
        }

        private bool AgregarEmpleado(byte tipo_doc, long nro_doc, string nombre, string apellido, 
             string domicilio, short cod_postal, string mail = null, string celular = null, string telefono = null)
        {

            try
            {
                empleado = new Empleado
                {
                    Nro_Doc = nro_doc,
                    Tipo_Doc = tipo_doc,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Celular = celular,
                    Mail = mail,
                    Domicilio = domicilio,
                    Cod_Postal = cod_postal
                };
                if (manejador_empleado.AgregarEmpleado(empleado)==false)
                {
                    errorProvider.SetError(label1, "Este codigo postal no existe.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR::::" + e);
                return false;
                throw;
            }
            return true;
        }

        private bool AgregarUsuario(Empleado empleado,string usuario,string password)
        {
            try
            {
                Dominio.Login nuevoLogin = new Dominio.Login
                {
                    username = usuario,
                    password = password,
                    Nro_Empleado = empleado.Nro_Empleado
                };
                manejador_empleado.AgregarLogin(nuevoLogin);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en LOGIN:::"+" "+e);
                return false;
                throw;
            }
            return true;
        }
        private bool VerificarCampos(string nro_documento,string nombre,string apellido,string domicilio,string usuario,string password )
        {
            //verificar si algun campo esta vacio, si lo esta retornar true.
            if (String.IsNullOrWhiteSpace(nro_documento) || String.IsNullOrWhiteSpace(nombre) ||  String.IsNullOrWhiteSpace(apellido)
                || String.IsNullOrWhiteSpace(domicilio) || String.IsNullOrWhiteSpace(usuario) || String.IsNullOrWhiteSpace(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos(txtNroDocumento.Text,txtNombre.Text,txtApellido.Text,txtDomicilio.Text,txtUsuario.Text,txtPassword.Text))
            {
                MessageBox.Show("Algun campo obligatorio esta vacio","Completar campos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                if(AgregarEmpleado((byte)comboTipoDoc.SelectedValue,Convert.ToInt64(txtNroDocumento.Text),txtNombre.Text,txtApellido.Text,
                    txtDomicilio.Text, (short)comboCiudades.SelectedValue, txtMail.Text, txtCelular.Text, txtTelefono.Text) == true)
                {
                    if (AgregarUsuario(empleado,txtUsuario.Text.Trim(),txtPassword.Text.Trim())==true)
                    {
                        MessageBox.Show("El empleado " + txtNombre.Text + " " + txtApellido.Text + " se agrego correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error con usuario y password");
                    }
                }
            }
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            Controlador.EspaciosKeyPress(e, sender);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            Controlador.EspaciosKeyPress(e, sender);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.EspaciosKeyPress(e, sender);
        }

        private void btnAgregarCodPostal_Click(object sender, EventArgs e)
        {
            frmAgregarCiudades agregarCiudades = new frmAgregarCiudades();
            agregarCiudades.ShowDialog();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void comboProvincias_SelectedValueChanged(object sender, EventArgs e)
        {
            listarComboCiudades();
        }

       
    }
}
