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


namespace UI.Clientes
{
    public partial class frmClientes : MaterialForm
    {
        public frmClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

            cargarCombo();
            comboTipoDoc.SelectedItem = 1;
        }

        private void cargarCombo()
        {
            comboTipoDoc.DataSource = TipoDocSesion.getSetTipoDoc;
            comboTipoDoc.DisplayMember = "Descripcion";
            comboTipoDoc.ValueMember = "Tipo_Doc";
        }

        private void LimpiarCampos()
        {
            comboTipoDoc.SelectedItem = 1;
            txtNombre.Text = "";
            txtNroDoc.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtMail.Text = "";
            txtDomicilio.Text = "";
            txtCodigoPostal.Text = "";
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtNroDoc.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtCelular.Text != "" && txtDomicilio.Text != ""
                && txtCodigoPostal.Text != "")
            {
                Cliente cargar_cliente = new Cliente
                {
                    Tipo_Doc = (byte)comboTipoDoc.SelectedValue,
                    Nro_Doc = Convert.ToInt64(txtNroDoc.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Mail = txtMail.Text,
                    Celular = txtCelular.Text,
                    Domicilio = txtDomicilio.Text,
                    Cod_Postal = Convert.ToInt16(txtCodigoPostal.Text),
                };
                ManejadorClientes nuevoCliente = new ManejadorClientes();
                nuevoCliente.agregarCliente(cargar_cliente);
                MessageBox.Show("Cliente " + txtNombre.Text + " " + txtApellido.Text + " agregado correctamente","Sistema",MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Algun campo esta vacio", "Completa los campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
             {
                 e.Handled = true;
             }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !Char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = true;
            }
            Controlador.EspaciosKeyPress(e,sender);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            Controlador.EspaciosKeyPress(e, sender);
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtRefrescar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        //TAB CONSULTAR!
        #region TAB_CONSULTAR

        private void ListarListClientes()
        {
            listClientes.Clear();
            ManejadorClientes obtenerClientes = new ManejadorClientes();

            this.listClientes.Columns.Add("Nro Doc", 100,HorizontalAlignment.Left);
            this.listClientes.Columns.Add("Nombre", 140, HorizontalAlignment.Center);
            this.listClientes.Columns.Add("Apellido", 140,HorizontalAlignment.Center);
            this.listClientes.Columns.Add("Celular", 150,HorizontalAlignment.Left);
            this.listClientes.Columns.Add("Domicilio", 100);
            this.listClientes.Columns.Add("Localidad", 100,HorizontalAlignment.Center);

            //trae una lista de Cliente
            var llenar_Lista = obtenerClientes.ListarClientes();

            foreach (var item in llenar_Lista)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = item,
                    Text = item.Nro_Doc.ToString()
                };
                listViewItem.SubItems.Add(item.Nombre);
                listViewItem.SubItems.Add(item.Apellido);
                listViewItem.SubItems.Add(item.Celular);
                listViewItem.SubItems.Add(item.Domicilio);
                //listViewItem.SubItems.Add(item.Ciudade.Nombre); disposed error
                listClientes.Items.Add(listViewItem);
            }

            //pintar los rows pares
            Controlador.PintarRowsListView(listClientes);

        }
        private void tabConsultar_Enter(object sender, EventArgs e)
        {
            ListarListClientes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listClientes.Clear();
            ListarListClientes();
        }

        private void menuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.listClientes.SelectedItems.Count > 0)
            {
                this.editarItem.Enabled = true;
                this.eliminarItem.Enabled = true;
            }else
            {
                this.editarItem.Enabled = false;
                this.eliminarItem.Enabled = false;
            }
        }

        private void eliminarItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?","Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ManejadorClientes manejadorCliente = new ManejadorClientes();
                var cliente = (Cliente)this.listClientes.SelectedItems[0].Tag;
                //manejadorCliente.borrarCliente(cliente);
                listClientes.Clear();
                ListarListClientes();
            }

        }

        private void editarItem_Click(object sender, EventArgs e)
        {
            ModificarCliente modificar_cliente = new ModificarCliente((Cliente)listClientes.SelectedItems[0].Tag);
            modificar_cliente.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                ListarListClientes();
            }

        }

        #endregion

        private void frmClientes_Deactivate(object sender, EventArgs e)
        {
            
            //main_menu.resetarEstilos();
        }
    }
}
