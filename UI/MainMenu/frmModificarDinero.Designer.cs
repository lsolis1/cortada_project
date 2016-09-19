namespace UI.MainMenu
{
    partial class frmModificarDinero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarDinero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioQuitar = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAgregar = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtAgregarDinero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioQuitar);
            this.groupBox1.Controls.Add(this.radioAgregar);
            this.groupBox1.Location = new System.Drawing.Point(75, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que desea hacer?";
            // 
            // radioQuitar
            // 
            this.radioQuitar.AutoSize = true;
            this.radioQuitar.Depth = 0;
            this.radioQuitar.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioQuitar.Location = new System.Drawing.Point(192, 28);
            this.radioQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.radioQuitar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioQuitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioQuitar.Name = "radioQuitar";
            this.radioQuitar.Ripple = true;
            this.radioQuitar.Size = new System.Drawing.Size(109, 30);
            this.radioQuitar.TabIndex = 6;
            this.radioQuitar.TabStop = true;
            this.radioQuitar.Text = "Quitar dinero";
            this.radioQuitar.UseVisualStyleBackColor = true;
            // 
            // radioAgregar
            // 
            this.radioAgregar.AutoSize = true;
            this.radioAgregar.Depth = 0;
            this.radioAgregar.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioAgregar.Location = new System.Drawing.Point(22, 28);
            this.radioAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.radioAgregar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAgregar.Name = "radioAgregar";
            this.radioAgregar.Ripple = true;
            this.radioAgregar.Size = new System.Drawing.Size(120, 30);
            this.radioAgregar.TabIndex = 5;
            this.radioAgregar.TabStop = true;
            this.radioAgregar.Text = "Agregar dinero";
            this.radioAgregar.UseVisualStyleBackColor = true;
            // 
            // txtAgregarDinero
            // 
            this.txtAgregarDinero.Depth = 0;
            this.txtAgregarDinero.Hint = "Monto";
            this.txtAgregarDinero.Location = new System.Drawing.Point(31, 42);
            this.txtAgregarDinero.MaxLength = 32767;
            this.txtAgregarDinero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAgregarDinero.Name = "txtAgregarDinero";
            this.txtAgregarDinero.PasswordChar = '\0';
            this.txtAgregarDinero.SelectedText = "";
            this.txtAgregarDinero.SelectionLength = 0;
            this.txtAgregarDinero.SelectionStart = 0;
            this.txtAgregarDinero.Size = new System.Drawing.Size(279, 23);
            this.txtAgregarDinero.TabIndex = 0;
            this.txtAgregarDinero.TabStop = false;
            this.txtAgregarDinero.UseSystemPasswordChar = false;
            this.txtAgregarDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarDinero_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(424, 293);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(76, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 288);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(513, 1);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAgregarDinero);
            this.groupBox2.Location = new System.Drawing.Point(75, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmModificarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmModificarDinero";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Dinero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAgregarDinero;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRadioButton radioAgregar;
        private MaterialSkin.Controls.MaterialRadioButton radioQuitar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}