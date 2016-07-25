﻿using System;
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

            //divider colors
            coloresDividers();

        }
        public void coloresDividers()
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
    }
}