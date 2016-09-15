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
//using UI.Clientes;
using UI.Login;
using LogicaDeNegocio;
using Dominio;
using UI.MainMenu;
using UI.Clientes;

namespace UI
{
    public partial class frmMainMenu : MaterialForm
    {

        public frmMainMenu()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

            //obtener nombre y apellido.
            lblUser.Text = Sesion.nombre_apellido;

            //divider colors
            coloresDividers();

            //inicio la caja
            SesionCaja.fecha_sesion = DateTime.Now.Date;
            SesionCaja.hora_inicio = DateTime.Now.TimeOfDay;

            //cargo tipos docs
            ManejadorDNI manejador_dni = new ManejadorDNI();
            manejador_dni.ListarDocumentos();

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
            //formulario turnos

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
        private void frmMainMenu_Activated(object sender, EventArgs e)
        {
            lblDinero.Text = "$" + SesionCaja.importe_actual.ToString();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form_clientes = new frmClientes();
            form_clientes.ShowDialog();
            //frmClientes formularioClientes = new frmClientes();
            //formularioClientes.ShowDialog();
        }

        private void btnModificarDinero_Click(object sender, EventArgs e)
        {
            frmModificarDinero modificarDinero = new frmModificarDinero();
            modificarDinero.ShowDialog();   
        }

        private void btnTurnosReservados_Click(object sender, EventArgs e)
        {
            //listviewMainMenu.Clear();

            //this.listviewMainMenu.Columns.Add("Nro Doc",100);
            //this.listviewMainMenu.Columns.Add("Apellido", 140);
            //this.listviewMainMenu.Columns.Add("Nombre", 140);
            //this.listviewMainMenu.Columns.Add("Hora", 100);
            //this.listviewMainMenu.Columns.Add("Empleado", 100);
            //this.listviewMainMenu.Columns.Add("Cancha", 100);
            //this.listviewMainMenu.Columns.Add("Tipo turno", 100);
            //this.listviewMainMenu.Columns.Add("Estado", 100);

            //var llenarLista = ManejadorTurnos.ListarTurnosHoy();

            //foreach (var item in llenarLista)
            //{
            //    var listViewItem = new ListViewItem
            //    {
            //        Tag = item.Nro_Doc,
            //        Text = item.Nro_Doc.ToString()
            //    };
            //    listViewItem.SubItems.Add(item.Cliente.Apellido);
            //    listViewItem.SubItems.Add(item.Cliente.Nombre);
            //    listViewItem.SubItems.Add(item.Hora.ToString()); //ver el formato Hora!
            //    listViewItem.SubItems.Add(item.Empleado.Nombre);
            //    listViewItem.SubItems.Add(item.Cancha.Descripcion);
            //    listViewItem.SubItems.Add(item.Tipos_Turno.Descripcion);
            //    listViewItem.SubItems.Add(item.Estado_Turno.Descripcion);
            //    if (item.Estado ==2)
            //    {
            //        listViewItem.BackColor = Color.FromArgb(170, 211, 215);
            //    }
            //    if (item.Estado==1 && DateTime.Now.TimeOfDay > item.Hora)
            //    {
            //        listViewItem.BackColor = Color.FromArgb(102, 186, 223);
            //        listViewItem.ForeColor = Color.White;
            //    }

            //    this.listviewMainMenu.Items.Add(listViewItem);
            //    }
        }

        private void btnListaEspera_Click(object sender, EventArgs e)
        {
            //listviewMainMenu.Clear();
            //this.listviewMainMenu.Columns.Add("Nro Doc", 120);
            //this.listviewMainMenu.Columns.Add("Nombre", 100);
            //this.listviewMainMenu.Columns.Add("Apellido", 140);
            //this.listviewMainMenu.Columns.Add("Celular", 140);
            //this.listviewMainMenu.Columns.Add("Hora", 100);
            //this.listviewMainMenu.Columns.Add("Empleado", 100);

            //var llenarLista = ManejadorListaDeEspera.MostrarListaDeEsperaHoy();
            //foreach (var item in llenarLista)
            //{
            //    var listViewItem = new ListViewItem
            //    {
            //        Tag = item.Nro_Doc,
            //        Text = item.Nro_Doc.ToString()
            //    };

            //    listViewItem.SubItems.Add(item.Cliente.Nombre);
            //    listViewItem.SubItems.Add(item.Cliente.Apellido);
            //    listViewItem.SubItems.Add(item.Cliente.Celular.ToString());
            //    listViewItem.SubItems.Add(item.Hora.ToString());
            //    listViewItem.SubItems.Add(item.Caja.Empleado.Nombre);

            //    this.listviewMainMenu.Items.Add(listViewItem);
            //}
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Caja nuevaCaja = new Caja();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var obtenerTotalHorasConectado = (DateTime.Now.TimeOfDay- SesionCaja.hora_inicio).ToString(@"hh\:mm\:ss");
                if (MessageBox.Show("Se cerrara la sesion." + Environment.NewLine + "Tiempo conectado: " + obtenerTotalHorasConectado+ Environment.NewLine + "Saldo final: "+SesionCaja.importe_actual.ToString(), "Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    nuevaCaja = new Caja
                    {
                        Nro_Empleado = Sesion.id_empleado,
                        Fecha = SesionCaja.fecha_sesion,
                        Hora_Inicio = SesionCaja.hora_inicio,
                        Hora_Fin = DateTime.Now.TimeOfDay,
                        Importe_Inicio = SesionCaja.importe_inicio,
                        Importe_Retiro = SesionCaja.importe_actual
                        
                    };
                    ManejadorCaja cerrarCaja = new ManejadorCaja();
                    cerrarCaja.CargarCaja(nuevaCaja);
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                nuevaCaja = new Caja
                {
                    Nro_Empleado = Sesion.id_empleado,
                    Fecha = SesionCaja.fecha_sesion,
                    Hora_Inicio = SesionCaja.hora_inicio,
                    Hora_Fin = DateTime.Now.TimeOfDay,
                    Importe_Inicio = SesionCaja.importe_inicio,
                    Importe_Retiro = SesionCaja.importe_actual

                };
                ManejadorCaja cerrarCaja = new ManejadorCaja();
                cerrarCaja.CargarCaja(nuevaCaja);
            }
        
        }

     
    }
}
