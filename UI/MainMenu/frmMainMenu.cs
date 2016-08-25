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
using UI.Clientes;
using UI.Login;
using LogicaDeNegocio;
using Dominio;
using UI.MainMenu;

namespace UI
{
    public partial class frmMainMenu : MaterialForm
    {
        public frmMainMenu(string nombre_apellido)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

            //obtener nombre y apellido.
            lblUser.Text = nombre_apellido;

            //mostrar dinero en caja
            lblDinero.Text = "$"+ManejadorCaja.ObtenerDineroEnCaja().ToString();

            //divider colors
            coloresDividers();

        }
        private void coloresDividers()
            {
                divider1.BackColor = Color.Black;
                divider2.BackColor = Color.Black;
                divider3.BackColor = Color.Black;
                divider4.BackColor = Color.Black;
                divider5.BackColor = Color.Black;
                divider6.BackColor = Color.Black;
                divider7.BackColor = Color.Black;
                divider8.BackColor = Color.FromArgb(229, 229, 229);
                divider9.BackColor = Color.FromArgb(110, 0, 0, 0);
            }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurnos formularioTurnos = new frmTurnos();
            formularioTurnos.ShowDialog();

        }

        private void frmMainMenu_Deactivate(object sender, EventArgs e)
        {
            coloresDividers();
            btnTurnos.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnKiosco.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnInformes.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnTema.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formularioClientes = new frmClientes();
            formularioClientes.ShowDialog();
        }

        private void btnModificarDinero_Click(object sender, EventArgs e)
        {
            frmModificarDinero modificarDinero = new frmModificarDinero();
            modificarDinero.ShowDialog();
            if (modificarDinero.DialogResult== DialogResult.OK)
            {
                lblDinero.Text = "$"+ManejadorCaja.ObtenerDineroEnCaja().ToString();
            }
            
        }

        private void btnTurnosReservados_Click(object sender, EventArgs e)
        {
            listviewMainMenu.Clear();

            this.listviewMainMenu.Columns.Add("Nro Doc",100);
            this.listviewMainMenu.Columns.Add("Apellido", 140);
            this.listviewMainMenu.Columns.Add("Nombre", 140);
            this.listviewMainMenu.Columns.Add("Hora", 100);
            this.listviewMainMenu.Columns.Add("Empleado", 100);
            this.listviewMainMenu.Columns.Add("Cancha", 100);
            this.listviewMainMenu.Columns.Add("Tipo turno", 100);
            this.listviewMainMenu.Columns.Add("Estado", 100);

            var llenarLista = ManejadorTurnos.ListarTurnosHoy();

            foreach (var item in llenarLista)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = item.Nro_Doc,
                    Text = item.Nro_Doc.ToString()
                };
                listViewItem.SubItems.Add(item.Cliente.Apellido);
                listViewItem.SubItems.Add(item.Cliente.Nombre);
                listViewItem.SubItems.Add(item.Hora.ToString()); //ver el formato Hora!
                listViewItem.SubItems.Add(item.Empleado.Nombre);
                listViewItem.SubItems.Add(item.Cancha.Descripcion);
                listViewItem.SubItems.Add(item.Tipos_Turno.Descripcion);
                listViewItem.SubItems.Add(item.Estado_Turno.Descripcion);
                if (item.Estado ==2)
                {
                    listViewItem.BackColor = Color.FromArgb(170, 211, 215);
                }
                if (item.Estado==1 && DateTime.Now.TimeOfDay > item.Hora)
                {
                    listViewItem.BackColor = Color.FromArgb(102, 186, 223);
                    listViewItem.ForeColor = Color.White;
                }

                this.listviewMainMenu.Items.Add(listViewItem);
                }
        }

        private void btnListaEspera_Click(object sender, EventArgs e)
        {
            listviewMainMenu.Clear();
            this.listviewMainMenu.Columns.Add("Nro Doc", 120);
            this.listviewMainMenu.Columns.Add("Nombre", 100);
            this.listviewMainMenu.Columns.Add("Apellido", 140);
            this.listviewMainMenu.Columns.Add("Celular", 140);
            this.listviewMainMenu.Columns.Add("Hora", 100);
            this.listviewMainMenu.Columns.Add("Empleado", 100);

            var llenarLista = ManejadorListaDeEspera.MostrarListaDeEsperaHoy();
            foreach (var item in llenarLista)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = item.Nro_Doc,
                    Text = item.Nro_Doc.ToString()
                };

                listViewItem.SubItems.Add(item.Cliente.Nombre);
                listViewItem.SubItems.Add(item.Cliente.Apellido);
                listViewItem.SubItems.Add(item.Cliente.Celular.ToString());
                listViewItem.SubItems.Add(item.Hora.ToString());
                listViewItem.SubItems.Add(item.Caja.Empleado.Nombre);

                this.listviewMainMenu.Items.Add(listViewItem);
            }
        }

       
    }
}
