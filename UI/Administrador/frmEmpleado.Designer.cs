namespace UI.Administrador
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNroDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAlta = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCiudades = new System.Windows.Forms.ComboBox();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregarCodPostal = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardarCambios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre(*)";
            this.txtNombre.Location = new System.Drawing.Point(59, 100);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(193, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Depth = 0;
            this.txtNroDocumento.Hint = "Nro Documento(*)";
            this.txtNroDocumento.Location = new System.Drawing.Point(300, 33);
            this.txtNroDocumento.MaxLength = 19;
            this.txtNroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.PasswordChar = '\0';
            this.txtNroDocumento.SelectedText = "";
            this.txtNroDocumento.SelectionLength = 0;
            this.txtNroDocumento.SelectionStart = 0;
            this.txtNroDocumento.Size = new System.Drawing.Size(193, 23);
            this.txtNroDocumento.TabIndex = 2;
            this.txtNroDocumento.TabStop = false;
            this.txtNroDocumento.UseSystemPasswordChar = false;
            this.txtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumento_KeyPress);
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(145, 35);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(107, 21);
            this.comboTipoDoc.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "Apellido(*)";
            this.txtApellido.Location = new System.Drawing.Point(300, 100);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(193, 23);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TabStop = false;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(59, 156);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(193, 23);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Depth = 0;
            this.txtCelular.Hint = "Celular";
            this.txtCelular.Location = new System.Drawing.Point(300, 156);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.Size = new System.Drawing.Size(193, 23);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TabStop = false;
            this.txtCelular.UseSystemPasswordChar = false;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.checkAlta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboCiudades);
            this.groupBox1.Controls.Add(this.comboProvincias);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.btnAgregarCodPostal);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtNroDocumento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Location = new System.Drawing.Point(87, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 511);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // checkAlta
            // 
            this.checkAlta.AutoSize = true;
            this.checkAlta.Depth = 0;
            this.checkAlta.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkAlta.Location = new System.Drawing.Point(227, 468);
            this.checkAlta.Margin = new System.Windows.Forms.Padding(0);
            this.checkAlta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkAlta.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkAlta.Name = "checkAlta";
            this.checkAlta.Ripple = true;
            this.checkAlta.Size = new System.Drawing.Size(96, 30);
            this.checkAlta.TabIndex = 17;
            this.checkAlta.Text = "Dar de alta";
            this.checkAlta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Provincia";
            // 
            // comboCiudades
            // 
            this.comboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudades.FormattingEnabled = true;
            this.comboCiudades.Location = new System.Drawing.Point(361, 276);
            this.comboCiudades.Name = "comboCiudades";
            this.comboCiudades.Size = new System.Drawing.Size(119, 21);
            this.comboCiudades.TabIndex = 14;
            // 
            // comboProvincias
            // 
            this.comboProvincias.BackColor = System.Drawing.SystemColors.Window;
            this.comboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(125, 276);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(121, 21);
            this.comboProvincias.TabIndex = 11;
            this.comboProvincias.SelectedValueChanged += new System.EventHandler(this.comboProvincias_SelectedValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password(*)";
            this.txtPassword.Location = new System.Drawing.Point(59, 431);
            this.txtPassword.MaxLength = 35;
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(434, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "Usuario(*)";
            this.txtUsuario.Location = new System.Drawing.Point(59, 384);
            this.txtUsuario.MaxLength = 35;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(434, 23);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // btnAgregarCodPostal
            // 
            this.btnAgregarCodPostal.AutoSize = true;
            this.btnAgregarCodPostal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCodPostal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCodPostal.Depth = 0;
            this.btnAgregarCodPostal.Icon = ((System.Drawing.Image)(resources.GetObject("btnAgregarCodPostal.Icon")));
            this.btnAgregarCodPostal.Location = new System.Drawing.Point(486, 270);
            this.btnAgregarCodPostal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCodPostal.Name = "btnAgregarCodPostal";
            this.btnAgregarCodPostal.Primary = false;
            this.btnAgregarCodPostal.Size = new System.Drawing.Size(36, 36);
            this.btnAgregarCodPostal.TabIndex = 11;
            this.btnAgregarCodPostal.UseVisualStyleBackColor = true;
            this.btnAgregarCodPostal.Click += new System.EventHandler(this.btnAgregarCodPostal_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Hint = "Domicilio(*)";
            this.txtDomicilio.Location = new System.Drawing.Point(59, 212);
            this.txtDomicilio.MaxLength = 20;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.Size = new System.Drawing.Size(434, 23);
            this.txtDomicilio.TabIndex = 7;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.UseSystemPasswordChar = false;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Mail";
            this.txtMail.Location = new System.Drawing.Point(59, 337);
            this.txtMail.MaxLength = 35;
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(434, 23);
            this.txtMail.TabIndex = 9;
            this.txtMail.TabStop = false;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(55, 35);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(70, 21);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo Doc";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(292, 589);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(150, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar empleado";
            this.btnAgregar.UseCustomBackColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.AutoSize = true;
            this.btnGuardarCambios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.Depth = 0;
            this.btnGuardarCambios.Icon = null;
            this.btnGuardarCambios.Location = new System.Drawing.Point(298, 589);
            this.btnGuardarCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Primary = true;
            this.btnGuardarCambios.Size = new System.Drawing.Size(139, 36);
            this.btnGuardarCambios.TabIndex = 11;
            this.btnGuardarCambios.Text = "guardar cambios";
            this.btnGuardarCambios.UseCustomBackColor = false;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 628);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmEmpleado";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroDocumento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCelular;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private System.Windows.Forms.Label lblTipoDoc;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarCodPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboCiudades;
        private System.Windows.Forms.ComboBox comboProvincias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCambios;
        private MaterialSkin.Controls.MaterialCheckBox checkAlta;
    }
}