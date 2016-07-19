namespace UI
{
    partial class frmTurnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlTurnos = new MaterialSkin.Controls.MaterialTabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControlTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTurnos
            // 
            this.tabControlTurnos.Controls.Add(this.tabRegistrar);
            this.tabControlTurnos.Controls.Add(this.tabPage2);
            this.tabControlTurnos.Depth = 0;
            this.tabControlTurnos.Location = new System.Drawing.Point(0, 115);
            this.tabControlTurnos.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlTurnos.Name = "tabControlTurnos";
            this.tabControlTurnos.SelectedIndex = 0;
            this.tabControlTurnos.Size = new System.Drawing.Size(1134, 540);
            this.tabControlTurnos.TabIndex = 0;
            this.tabControlTurnos.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlTurnos_Selecting);
            this.tabControlTurnos.TabIndexChanged += new System.EventHandler(this.tabControlTurnos_TabIndexChanged);
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(1126, 514);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabSelector
            // 
            this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelector.BaseTabControl = this.tabControlTurnos;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(0, 64);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(1134, 49);
            this.tabSelector.TabIndex = 1;
            this.tabSelector.Text = "selector";
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 692);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.tabControlTurnos);
            this.Name = "frmTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTurnos_FormClosing);
            this.tabControlTurnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlTurnos;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
    }
}