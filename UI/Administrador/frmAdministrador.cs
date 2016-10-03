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
    public partial class frmAdministrador : MaterialForm
    {
        ManejadorEmpleados manejador_empleado = new ManejadorEmpleados();
        ConfiguracionComplejo configuracion_complejo = new ConfiguracionComplejo();
        public frmAdministrador()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);

        }

        #region TAB EMPLEADOS

        private void ListarEmpleados()
        {
            listEmpleados.Clear();
            ManejadorEmpleados manejadorEmpleados = new ManejadorEmpleados();

            this.listEmpleados.Columns.Add("Nro Doc",100);
            this.listEmpleados.Columns.Add("Nombre", 150, HorizontalAlignment.Center);
            this.listEmpleados.Columns.Add("Apellido", 150, HorizontalAlignment.Center);
            this.listEmpleados.Columns.Add("Celular", 140);
            this.listEmpleados.Columns.Add("Mail", 140);
            this.listEmpleados.Columns.Add("Domicilio", 120);
            this.listEmpleados.Columns.Add("Localidad", 130, HorizontalAlignment.Center);
            var lista_de_empleados = manejadorEmpleados.ListarEmpleados();
            foreach (var item in lista_de_empleados)
            {
                var listViewItem = new ListViewItem {
                    Tag = item,
                    Text = item.Nro_Doc.ToString()
                };
                listViewItem.SubItems.Add(item.Nombre);
                listViewItem.SubItems.Add(item.Apellido);
                listViewItem.SubItems.Add(item.Celular);
                listViewItem.SubItems.Add(item.Mail);
                listViewItem.SubItems.Add(item.Domicilio);
                listViewItem.SubItems.Add(item.Ciudade.Nombre);

                listEmpleados.Items.Add(listViewItem);
                if (item.Fecha_Baja !=null)
                {
                    listViewItem.BackColor = Color.FromArgb(219, 92, 92);
                    listViewItem.ForeColor = Color.FromArgb(240, 240, 240);
                }
            }
            
        }
        private void tabAdministrador_Enter(object sender, EventArgs e)
        {
            ListarEmpleados();
        }


        private void MenuStripEmpleados_Opening(object sender, CancelEventArgs e)
        {
            if (this.listEmpleados.SelectedItems.Count > 0)
            {
                this.editarItem.Enabled = true;
                this.eliminarItem.Enabled = true;
            }
            else
            {
                this.editarItem.Enabled = false;
                this.eliminarItem.Enabled = false;
            }
        }

        private void editarItem_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado((Empleado)listEmpleados.SelectedItems[0].Tag);
            frmEmpleado.ShowDialog();
            if (frmEmpleado.DialogResult == DialogResult.OK)
            {
                ListarEmpleados();
            }
        }
        private void eliminarItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro?","Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var empleado_eliminar = (Empleado)this.listEmpleados.SelectedItems[0].Tag;
                if (empleado_eliminar.Fecha_Baja==null)
                {
                    empleado_eliminar.Fecha_Baja = DateTime.Now;
                    manejador_empleado.ModificarEmpleado(empleado_eliminar);
                    ListarEmpleados();
                }
                else
                {
                    MessageBox.Show("Este cliente ya se encuentra eliminado.","anda a la cancha");
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado();
            frmEmpleado.ShowDialog();
            if (frmEmpleado.DialogResult == DialogResult.OK)
            {
                ListarEmpleados();
            }
        }


        #endregion

        #region TAB CONFIGURACION
        CheckBox[] _checkbox = new CheckBox[7];
        private void getHorarosDB()
        {
            //verificar el tipo de dato de los horarios en la BD.
            var tabla_dias_atencion = configuracion_complejo.getHorarios();
            foreach (var item in tabla_dias_atencion)
            {
                switch (item.id_dia)
                {
                    case 1:
                        if (item.hora_mañana!=null)
                        {
                            timeDomingoMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeDomingoMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkDomingo,timeDomingoMañanaHoraDesde,timeDomingoMañanaHoraHasta);
                            
                        }
                        timeDomingoTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeDomingoTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 2:
                        if (item.hora_mañana!=null)
                        {
                            timeLunesMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeLunesMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkLunes,timeLunesMañanaHoraDesde,timeLunesMañanaHoraHasta);
                        }
                        timeLunesTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeLunesTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 3:
                        if (item.hora_mañana != null)
                        {
                            timeMartesMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeMartesMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkMartes, timeMartesMañanaHoraDesde, timeMartesMañanaHoraHasta);
                        }
                        timeMartesTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeMartesTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 4:
                        if (item.hora_mañana != null)
                        {
                            timeMiercolesMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeMiercolesMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkMiercoles, timeMiercolesMañanaHoraDesde, timeMiercolesMañanaHoraHasta);
                        }
                        timeMiercolesTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeMiercolesTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 5:
                        if (item.hora_mañana != null)
                        {
                            timeJuevesMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeJuevesMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkJueves, timeJuevesMañanaHoraDesde, timeJuevesMañanaHoraHasta);
                        }
                        timeJuevesTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeJuevesTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 6:
                        if (item.hora_mañana != null)
                        {
                            timeViernesMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeViernesMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkViernes, timeViernesMañanaHoraDesde, timeViernesMañanaHoraHasta);
                        }
                        timeViernesTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeViernesTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    case 7:
                        if (item.hora_mañana != null)
                        {
                            timeSabadoMañanaHoraDesde.Value = DateTime.Today.Add(item.hora_mañana.Value);
                            timeSabadoMañanaHoraHasta.Value = DateTime.Today.Add(item.fin_hora_mañana.Value);
                        }
                        else
                        {
                            HoraMañanaEsNulo(checkSabado, timeSabadoMañanaHoraDesde, timeSabadoMañanaHoraHasta);
                        }
                        timeSabadoTardeHoraDesde.Value = DateTime.Today.Add(item.hora_tarde);
                        timeSabadoTardeHoraHasta.Value = DateTime.Today.Add(item.fin_hora_tarde);
                        break;
                    default:
                        break;
                }
            }
        }
        private void HoraMañanaEsNulo(CheckBox checkbox,DateTimePicker timepickerDesde,DateTimePicker timepickerHasta)
        {
            checkbox.Checked = true;
            timepickerDesde.Enabled = false;
            timepickerHasta.Enabled = false;
        }

        private void tabConfiguracion_Enter(object sender, EventArgs e)
        {
            getHorarosDB();
            CargarCheckbox();
            CargarDateTimeMañanaDesde();
            CargarDateTimeMañanaHasta();
            CargarDateTimeTardeDesde();
            CargarDateTimeTardeHasta();
            CheckChangeProcedimiento();
            InicializarControlTimePicker();
            MostrarDatosComplejo();
        }
        
        private void MostrarDatosComplejo()
        {
            var datos_complejo = configuracion_complejo.ListarDatosComplejo();
            txtNombreComplejo.Text = datos_complejo.nombre_compejo;
            txtDireccionComplejo.Text = datos_complejo.direccion;
            txtTelefonoComplejo.Text = datos_complejo.telefono;
        }
        private bool SetDatosComplejo()
        {
            if (String.IsNullOrWhiteSpace(txtNombreComplejo.Text) || String.IsNullOrWhiteSpace(txtDireccionComplejo.Text)
                || String.IsNullOrWhiteSpace(txtTelefonoComplejo.Text))
            {
                return false;
            }
            else
            {
                var datos_complejo = configuracion_complejo.ListarDatosComplejo();
                datos_complejo.nombre_compejo = txtNombreComplejo.Text;
                datos_complejo.direccion = txtDireccionComplejo.Text;
                datos_complejo.telefono = txtTelefonoComplejo.Text;
                configuracion_complejo.CambiarDatosComplejo(datos_complejo);
                return true;
            }
            
        }
        private void CargarCheckbox()
        {
            _checkbox[0] = checkDomingo;
            _checkbox[1] = checkLunes;
            _checkbox[2] = checkMartes;
            _checkbox[3] = checkMiercoles;
            _checkbox[4] = checkJueves;
            _checkbox[5] = checkViernes;
            _checkbox[6] = checkSabado;
        }
        DateTimePicker[] _timePickerDesde = new DateTimePicker[7];
        DateTimePicker[] _timePickerHasta = new DateTimePicker[7];
        private void CargarDateTimeMañanaDesde()
        {
            _timePickerDesde[0] = timeDomingoMañanaHoraDesde;
            _timePickerDesde[1] = timeLunesMañanaHoraDesde;
            _timePickerDesde[2] = timeMartesMañanaHoraDesde;
            _timePickerDesde[3] = timeMiercolesMañanaHoraDesde;
            _timePickerDesde[4] = timeJuevesMañanaHoraDesde;
            _timePickerDesde[5] = timeViernesMañanaHoraDesde;
            _timePickerDesde[6] = timeSabadoMañanaHoraDesde;
        }
        private void CargarDateTimeMañanaHasta()
        {
            _timePickerHasta[0] = timeDomingoMañanaHoraHasta;
            _timePickerHasta[1] = timeLunesMañanaHoraHasta;
            _timePickerHasta[2] = timeMartesMañanaHoraHasta;
            _timePickerHasta[3] = timeMiercolesMañanaHoraHasta;
            _timePickerHasta[4] = timeJuevesMañanaHoraHasta;
            _timePickerHasta[5] = timeViernesMañanaHoraHasta;
            _timePickerHasta[6] = timeSabadoMañanaHoraHasta;
        }
        DateTimePicker[] _timePickerTardeDesde = new DateTimePicker[7];
        DateTimePicker[] _timePickerTardeHasta = new DateTimePicker[7];
        private void CargarDateTimeTardeDesde()
        {
            _timePickerTardeDesde[0] = timeDomingoTardeHoraDesde;
            _timePickerTardeDesde[1] = timeLunesTardeHoraDesde;
            _timePickerTardeDesde[2] = timeMartesTardeHoraDesde;
            _timePickerTardeDesde[3] = timeMiercolesTardeHoraDesde;
            _timePickerTardeDesde[4] = timeJuevesTardeHoraDesde;
            _timePickerTardeDesde[5] = timeViernesTardeHoraDesde;
            _timePickerTardeDesde[6] = timeSabadoTardeHoraDesde;
        }
        private void CargarDateTimeTardeHasta()
        {
            _timePickerTardeHasta[0] = timeDomingoTardeHoraHasta;
            _timePickerTardeHasta[1] = timeLunesTardeHoraHasta;
            _timePickerTardeHasta[2] = timeMartesTardeHoraHasta;
            _timePickerTardeHasta[3] = timeMiercolesTardeHoraHasta;
            _timePickerTardeHasta[4] = timeJuevesTardeHoraHasta;
            _timePickerTardeHasta[5] = timeViernesTardeHoraHasta;
            _timePickerTardeHasta[6] = timeSabadoTardeHoraHasta;
        }
        private void CheckChangeProcedimiento()
        {
            for (int i = 0; i < _checkbox.Length; i++)
            {
                _checkbox[i].CheckedChanged += new EventHandler(DispararEventoCheckBox);
                
            }

        }

        private void DispararEventoCheckBox(object sender,EventArgs e)
        {
            for (int i = 0; i < _checkbox.Length; i++)
            {
                if (_checkbox[i].Checked)
                {
                    for (int j = 0; j < _timePickerDesde.Length; j++)
                    {
                        for (int k = 0; k < _timePickerHasta.Length; k++)
                        {
                            if (i==j && i==k)
                            {
                                _timePickerDesde[j].Enabled = false;
                                _timePickerHasta[k].Enabled = false;
                            }

                        }
                    }
                }
                else
                {
                    for (int j = 0; j < _timePickerDesde.Length; j++)
                    {
                        for (int k = 0; k < _timePickerHasta.Length; k++)
                        {
                            if (i == j && i == k)
                            {
                                _timePickerDesde[j].Enabled = true;
                                _timePickerHasta[k].Enabled = true;
                            }

                        }
                    }
                }
            }
        }
        private void tabConfiguracion_Leave(object sender, EventArgs e)
        {
            
        }
        private void InicializarControlTimePicker()
        {
            for (int i = 0; i < _timePickerDesde.Length; i++)
            {
                    _timePickerDesde[i].MinDate = DateTime.Parse("7:00:00");
                    _timePickerDesde[i].MaxDate = DateTime.Parse("11:00:00");
                    _timePickerHasta[i].MinDate = DateTime.Parse("8:00:00");
                    _timePickerHasta[i].MaxDate = DateTime.Parse("12:00:00");

                    _timePickerTardeDesde[i].MinDate = DateTime.Parse("12:00:00");
                    _timePickerTardeDesde[i].MaxDate = DateTime.Parse("22:00:00");
                    _timePickerTardeHasta[i].MinDate = DateTime.Parse("13:00:00");
                    _timePickerTardeHasta[i].MaxDate = DateTime.Parse("23:59:00");
            }
        }
        private bool VerificarHoras()
        {
            int bandera = 0;
            for (int i = 0; i < _timePickerDesde.Length; i++)
            {
                if (_checkbox[i].Checked == false)
                {
                    if (_timePickerDesde[i].Value >= _timePickerHasta[i].Value || _timePickerTardeDesde[i].Value >= _timePickerTardeHasta[i].Value)
                    {
                        bandera = bandera + 1;
                    }
                }
                else
                {
                    if (_timePickerTardeDesde[i].Value >= _timePickerTardeHasta[i].Value)
                    {
                        bandera = bandera + 1;
                    }
                }
               
            }
            if (bandera >0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGuardarCambiosConfiguracion_Click(object sender, EventArgs e)
        {
            if (VerificarHoras())
            {
                var horas = configuracion_complejo.getHorarios();
                for (int i = 0; i < horas.Count; i++)
                {
                    if (_checkbox[i].Checked)
                    {
                        horas[i].hora_mañana = null;
                        horas[i].fin_hora_mañana = null;
                    }
                    else
                    {
                        horas[i].hora_mañana = TimeSpan.Parse(_timePickerDesde[i].Value.ToString("HH:mm"));
                        horas[i].fin_hora_mañana = TimeSpan.Parse(_timePickerHasta[i].Value.ToString("HH:mm"));
                    }
                    horas[i].hora_tarde = TimeSpan.Parse(_timePickerTardeDesde[i].Value.ToString("HH:mm"));
                    horas[i].fin_hora_tarde = TimeSpan.Parse(_timePickerTardeHasta[i].Value.ToString("HH:mm"));
                }
                configuracion_complejo.setHorarios(horas);
            }
            else
            {
                MessageBox.Show("Uno o más horarios son incorrectos. Verifique que el horario de apertura sea menor que el horario de cierre para cada turno(mañana y tarade)",
                    "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (SetDatosComplejo())
            {
                MessageBox.Show("Los cambios se realizaron  correctamente.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Verifique que los campos no esten nulos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }
        private void txtTelefonoComplejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtNombreComplejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.EspaciosKeyPress(e, sender);
        }
        private void txtDireccionComplejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.EspaciosKeyPress(e, sender);
        }
        #endregion


    }
}
