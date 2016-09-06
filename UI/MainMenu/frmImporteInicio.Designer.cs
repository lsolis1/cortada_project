namespace UI.MainMenu
{
    partial class frmImporteInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImporteInicio));
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMontoInicio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDinero = new System.Windows.Forms.Label();
            this.txtRepetirMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(176, 160);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(74, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseCustomBackColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtMontoInicio
            // 
            this.txtMontoInicio.Depth = 0;
            this.txtMontoInicio.Hint = "Monto de inicio";
            this.txtMontoInicio.Location = new System.Drawing.Point(79, 100);
            this.txtMontoInicio.MaxLength = 32767;
            this.txtMontoInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoInicio.Name = "txtMontoInicio";
            this.txtMontoInicio.PasswordChar = '\0';
            this.txtMontoInicio.SelectedText = "";
            this.txtMontoInicio.SelectionLength = 0;
            this.txtMontoInicio.SelectionStart = 0;
            this.txtMontoInicio.Size = new System.Drawing.Size(311, 23);
            this.txtMontoInicio.TabIndex = 1;
            this.txtMontoInicio.TabStop = false;
            this.txtMontoInicio.UseSystemPasswordChar = false;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(27, 110);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(29, 31);
            this.lblDinero.TabIndex = 2;
            this.lblDinero.Text = "$";
            // 
            // txtRepetirMonto
            // 
            this.txtRepetirMonto.Depth = 0;
            this.txtRepetirMonto.Hint = "Repetir monto";
            this.txtRepetirMonto.Location = new System.Drawing.Point(79, 129);
            this.txtRepetirMonto.MaxLength = 32767;
            this.txtRepetirMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRepetirMonto.Name = "txtRepetirMonto";
            this.txtRepetirMonto.PasswordChar = '\0';
            this.txtRepetirMonto.SelectedText = "";
            this.txtRepetirMonto.SelectionLength = 0;
            this.txtRepetirMonto.SelectionStart = 0;
            this.txtRepetirMonto.Size = new System.Drawing.Size(311, 23);
            this.txtRepetirMonto.TabIndex = 3;
            this.txtRepetirMonto.TabStop = false;
            this.txtRepetirMonto.UseSystemPasswordChar = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmImporteInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 206);
            this.Controls.Add(this.txtRepetirMonto);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.txtMontoInicio);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "frmImporteInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese el importe inicial";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoInicio;
        private System.Windows.Forms.Label lblDinero;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRepetirMonto;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}