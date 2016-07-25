namespace UI.Clientes
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControlClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnRefrescarCampos = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegistrarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.successProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabControlClientes;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1135, 49);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Controls.Add(this.tabPage2);
            this.tabControlClientes.Depth = 0;
            this.tabControlClientes.Location = new System.Drawing.Point(0, 114);
            this.tabControlClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(1135, 541);
            this.tabControlClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblTitulo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1127, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(438, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos del nuevo cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.cmbProvincia);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.btnRefrescarCampos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnRegistrarCliente);
            this.groupBox1.Controls.Add(this.materialDivider1);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(274, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 442);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los campos";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Depth = 0;
            this.txtCodigoPostal.Hint = "Codigo Postal(*)";
            this.txtCodigoPostal.Location = new System.Drawing.Point(357, 280);
            this.txtCodigoPostal.MaxLength = 32767;
            this.txtCodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.SelectedText = "";
            this.txtCodigoPostal.SelectionLength = 0;
            this.txtCodigoPostal.SelectionStart = 0;
            this.txtCodigoPostal.Size = new System.Drawing.Size(265, 23);
            this.txtCodigoPostal.TabIndex = 8;
            this.txtCodigoPostal.TabStop = false;
            this.txtCodigoPostal.UseSystemPasswordChar = false;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(55, 278);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(98, 25);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia(*)";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(159, 282);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(111, 21);
            this.cmbProvincia.TabIndex = 7;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(11, 39);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(139, 19);
            this.lblTipoDoc.TabIndex = 12;
            this.lblTipoDoc.Text = "Tipo de documento(*)";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Depth = 0;
            this.txtNumeroDocumento.Hint = "Documento(*)";
            this.txtNumeroDocumento.Location = new System.Drawing.Point(357, 39);
            this.txtNumeroDocumento.MaxLength = 32767;
            this.txtNumeroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.PasswordChar = '\0';
            this.txtNumeroDocumento.SelectedText = "";
            this.txtNumeroDocumento.SelectionLength = 0;
            this.txtNumeroDocumento.SelectionStart = 0;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(265, 23);
            this.txtNumeroDocumento.TabIndex = 2;
            this.txtNumeroDocumento.TabStop = false;
            this.txtNumeroDocumento.UseSystemPasswordChar = false;
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(159, 39);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(111, 21);
            this.cmbTipoDocumento.TabIndex = 1;
            // 
            // btnRefrescarCampos
            // 
            this.btnRefrescarCampos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefrescarCampos.AutoSize = true;
            this.btnRefrescarCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefrescarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescarCampos.Depth = 0;
            this.btnRefrescarCampos.Icon = null;
            this.btnRefrescarCampos.Location = new System.Drawing.Point(181, 400);
            this.btnRefrescarCampos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefrescarCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefrescarCampos.Name = "btnRefrescarCampos";
            this.btnRefrescarCampos.Primary = false;
            this.btnRefrescarCampos.Size = new System.Drawing.Size(148, 36);
            this.btnRefrescarCampos.TabIndex = 12;
            this.btnRefrescarCampos.TabStop = false;
            this.btnRefrescarCampos.Text = "refrescar campos";
            this.btnRefrescarCampos.UseVisualStyleBackColor = true;
            this.btnRefrescarCampos.Click += new System.EventHandler(this.btnRefrescarCampos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre(*)";
            this.txtNombre.Location = new System.Drawing.Point(15, 116);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(265, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrarCliente.AutoSize = true;
            this.btnRegistrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCliente.Depth = 0;
            this.btnRegistrarCliente.Icon = null;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(357, 400);
            this.btnRegistrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Primary = true;
            this.btnRegistrarCliente.Size = new System.Drawing.Size(143, 36);
            this.btnRegistrarCliente.TabIndex = 10;
            this.btnRegistrarCliente.TabStop = false;
            this.btnRegistrarCliente.Text = "Registrar cliente";
            this.btnRegistrarCliente.UseCustomBackColor = false;
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 392);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(666, 48);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "Apellido(*)";
            this.txtApellido.Location = new System.Drawing.Point(357, 116);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(265, 23);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TabStop = false;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Mail";
            this.txtMail.Location = new System.Drawing.Point(180, 347);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(320, 23);
            this.txtMail.TabIndex = 9;
            this.txtMail.TabStop = false;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Hint = "Domicilio(*)";
            this.txtDomicilio.Location = new System.Drawing.Point(15, 187);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.Size = new System.Drawing.Size(274, 23);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.UseSystemPasswordChar = false;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Depth = 0;
            this.txtCelular.Hint = "Celular(*)";
            this.txtCelular.Location = new System.Drawing.Point(357, 187);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.Size = new System.Drawing.Size(265, 23);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TabStop = false;
            this.txtCelular.UseSystemPasswordChar = false;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1127, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // successProvider
            // 
            this.successProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.successProvider.ContainerControl = this;
            this.successProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("successProvider.Icon")));
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 692);
            this.Controls.Add(this.tabControlClientes);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCelular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnRefrescarCampos;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label lblTipoDoc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoPostal;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider successProvider;
    }
}