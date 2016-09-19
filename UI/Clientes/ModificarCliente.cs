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
namespace UI.Clientes
{
    public partial class ModificarCliente : MaterialForm
    {
        private Cliente cliente_actual;
        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

            //verificar si el cliente esta dado de baja.
            this.cliente_actual = cliente;
            if (cliente_actual.Fecha_Baja ==null)
            {
                checkDarDeAlta.Enabled = false;
            }

            //llenar combo
            comboTipoDoc.DataSource = TipoDocSesion.getSetTipoDoc;
            comboTipoDoc.ValueMember = "Tipo_Doc";
            comboTipoDoc.DisplayMember = "Descripcion";

            LlenarCampos();
        }

       private void Modificar_cliente()
        {
            cliente_actual.Nombre = txtNombre.Text;
            cliente_actual.Apellido = txtApellido.Text;
            cliente_actual.Nro_Doc = Convert.ToInt64(txtDocumento.Text);
            cliente_actual.Tipo_Doc = (byte)comboTipoDoc.SelectedValue;
            cliente_actual.Mail = txtMail.Text;
            cliente_actual.Celular = txtCelular.Text;
            cliente_actual.Domicilio = txtDomicilio.Text;
            cliente_actual.Cod_Postal = Convert.ToInt16(txtCodPostal.Text);
            if (checkDarDeAlta.Checked ==true)
            {
                cliente_actual.Fecha_Baja = null;
            }
        }

        private void LlenarCampos()
        {
            txtNombre.Text = cliente_actual.Nombre;
            txtApellido.Text = cliente_actual.Apellido;
            txtDocumento.Text = cliente_actual.Nro_Doc.ToString();
            comboTipoDoc.SelectedItem = cliente_actual.Tipo_Doc;
            txtMail.Text = cliente_actual.Mail;
            txtCelular.Text = cliente_actual.Celular;
            txtDomicilio.Text = cliente_actual.Domicilio;
            txtCodPostal.Text = cliente_actual.Cod_Postal.ToString();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Modificar_cliente();
            ManejadorClientes manejadorClientes = new ManejadorClientes();
            manejadorClientes.ModificarCliente(cliente_actual);
            MessageBox.Show("Cliente modificado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
