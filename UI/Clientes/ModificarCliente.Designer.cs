namespace UI.Clientes
{
    partial class ModificarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDarDeAlta = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDarDeAlta);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtCodPostal);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Location = new System.Drawing.Point(124, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkDarDeAlta
            // 
            this.checkDarDeAlta.AutoSize = true;
            this.checkDarDeAlta.Depth = 0;
            this.checkDarDeAlta.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDarDeAlta.Location = new System.Drawing.Point(187, 265);
            this.checkDarDeAlta.Margin = new System.Windows.Forms.Padding(0);
            this.checkDarDeAlta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDarDeAlta.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDarDeAlta.Name = "checkDarDeAlta";
            this.checkDarDeAlta.Ripple = true;
            this.checkDarDeAlta.Size = new System.Drawing.Size(96, 30);
            this.checkDarDeAlta.TabIndex = 1;
            this.checkDarDeAlta.Text = "Dar de alta";
            this.checkDarDeAlta.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Mail";
            this.txtMail.Location = new System.Drawing.Point(234, 203);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(173, 23);
            this.txtMail.TabIndex = 7;
            this.txtMail.TabStop = false;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Depth = 0;
            this.txtCodPostal.Hint = "Codigo postal";
            this.txtCodPostal.Location = new System.Drawing.Point(21, 203);
            this.txtCodPostal.MaxLength = 32767;
            this.txtCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.PasswordChar = '\0';
            this.txtCodPostal.SelectedText = "";
            this.txtCodPostal.SelectionLength = 0;
            this.txtCodPostal.SelectionStart = 0;
            this.txtCodPostal.Size = new System.Drawing.Size(173, 23);
            this.txtCodPostal.TabIndex = 6;
            this.txtCodPostal.TabStop = false;
            this.txtCodPostal.UseSystemPasswordChar = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Hint = "Domicilio";
            this.txtDomicilio.Location = new System.Drawing.Point(234, 139);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.Size = new System.Drawing.Size(173, 23);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.UseSystemPasswordChar = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Depth = 0;
            this.txtCelular.Hint = "Celular";
            this.txtCelular.Location = new System.Drawing.Point(21, 139);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.Size = new System.Drawing.Size(173, 23);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.TabStop = false;
            this.txtCelular.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.Location = new System.Drawing.Point(234, 72);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(173, 23);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TabStop = false;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(21, 72);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(173, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "Nro Documento";
            this.txtDocumento.Location = new System.Drawing.Point(234, 19);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(195, 23);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(21, 19);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDoc.TabIndex = 0;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.AutoSize = true;
            this.btnGuardarCambios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.Depth = 0;
            this.btnGuardarCambios.Icon = null;
            this.btnGuardarCambios.Location = new System.Drawing.Point(641, 443);
            this.btnGuardarCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Primary = true;
            this.btnGuardarCambios.Size = new System.Drawing.Size(139, 36);
            this.btnGuardarCambios.TabIndex = 1;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseCustomBackColor = false;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 435);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(790, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 483);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCelular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private MaterialSkin.Controls.MaterialCheckBox checkDarDeAlta;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCambios;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}