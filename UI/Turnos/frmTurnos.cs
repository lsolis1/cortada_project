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


namespace UI
{
    public partial class frmTurnos : MaterialForm
    {

        public frmTurnos()
        {
            InitializeComponent();
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal500, Accent.DeepOrange100, TextShade.WHITE);


        }

        private void frmTurnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tabControlTurnos_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControlTurnos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex==1)
            {
            
              
            }
        }
    }
}
