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
            this.selectorClientes = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCiudad = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtRefrescar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCelular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNroDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.txtBuscarClienteNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkClientesEliminados = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listClientes = new System.Windows.Forms.ListView();
            this.menuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.comboCiudades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // selectorClientes
            // 
            this.selectorClientes.BaseTabControl = this.tabClientes;
            this.selectorClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectorClientes.Depth = 0;
            this.selectorClientes.Location = new System.Drawing.Point(-2, 64);
            this.selectorClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectorClientes.Name = "selectorClientes";
            this.selectorClientes.Size = new System.Drawing.Size(1028, 46);
            this.selectorClientes.TabIndex = 0;
            this.selectorClientes.Text = "materialTabSelector1";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabConsultar);
            this.tabClientes.Depth = 0;
            this.tabClientes.Location = new System.Drawing.Point(-2, 111);
            this.tabClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(1028, 645);
            this.tabClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboCiudades);
            this.groupBox1.Controls.Add(this.btnAgregarCiudad);
            this.groupBox1.Controls.Add(this.comboProvincias);
            this.groupBox1.Controls.Add(this.txtRefrescar);
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(247, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 539);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.AutoSize = true;
            this.btnAgregarCiudad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCiudad.Depth = 0;
            this.btnAgregarCiudad.Icon = ((System.Drawing.Image)(resources.GetObject("btnAgregarCiudad.Icon")));
            this.btnAgregarCiudad.Location = new System.Drawing.Point(479, 414);
            this.btnAgregarCiudad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Primary = false;
            this.btnAgregarCiudad.Size = new System.Drawing.Size(36, 36);
            this.btnAgregarCiudad.TabIndex = 10;
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
            // 
            // txtRefrescar
            // 
            this.txtRefrescar.AutoSize = true;
            this.txtRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRefrescar.Depth = 0;
            this.txtRefrescar.Icon = null;
            this.txtRefrescar.Location = new System.Drawing.Point(147, 496);
            this.txtRefrescar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRefrescar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRefrescar.Name = "txtRefrescar";
            this.txtRefrescar.Primary = false;
            this.txtRefrescar.Size = new System.Drawing.Size(148, 36);
            this.txtRefrescar.TabIndex = 10;
            this.txtRefrescar.Text = "Refrescar campos";
            this.txtRefrescar.UseVisualStyleBackColor = true;
            this.txtRefrescar.Click += new System.EventHandler(this.txtRefrescar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSize = true;
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.Icon = null;
            this.btnAgregarCliente.Location = new System.Drawing.Point(302, 496);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Primary = true;
            this.btnAgregarCliente.Size = new System.Drawing.Size(132, 36);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "AGREGAR CLIENTE";
            this.btnAgregarCliente.UseCustomBackColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Hint = "Domicilio";
            this.txtDomicilio.Location = new System.Drawing.Point(91, 367);
            this.txtDomicilio.MaxLength = 20;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.Size = new System.Drawing.Size(343, 23);
            this.txtDomicilio.TabIndex = 7;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.UseSystemPasswordChar = false;
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Mail";
            this.txtMail.Location = new System.Drawing.Point(91, 310);
            this.txtMail.MaxLength = 30;
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(343, 23);
            this.txtMail.TabIndex = 6;
            this.txtMail.TabStop = false;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Depth = 0;
            this.txtCelular.Hint = "Celular";
            this.txtCelular.Location = new System.Drawing.Point(91, 248);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.Size = new System.Drawing.Size(343, 23);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TabStop = false;
            this.txtCelular.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.Location = new System.Drawing.Point(91, 183);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(343, 23);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TabStop = false;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Depth = 0;
            this.txtNroDoc.Hint = "Nro Doc";
            this.txtNroDoc.Location = new System.Drawing.Point(264, 45);
            this.txtNroDoc.MaxLength = 19;
            this.txtNroDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PasswordChar = '\0';
            this.txtNroDoc.SelectedText = "";
            this.txtNroDoc.SelectionLength = 0;
            this.txtNroDoc.SelectionStart = 0;
            this.txtNroDoc.Size = new System.Drawing.Size(170, 23);
            this.txtNroDoc.TabIndex = 2;
            this.txtNroDoc.TabStop = false;
            this.txtNroDoc.UseSystemPasswordChar = false;
            this.txtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDoc_KeyPress);
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(91, 45);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDoc.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(91, 117);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(343, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // tabConsultar
            // 
            this.tabConsultar.BackColor = System.Drawing.Color.White;
            this.tabConsultar.Controls.Add(this.txtBuscarClienteNombre);
            this.tabConsultar.Controls.Add(this.txtBuscarCliente);
            this.tabConsultar.Controls.Add(this.checkClientesEliminados);
            this.tabConsultar.Controls.Add(this.btnConsultar);
            this.tabConsultar.Controls.Add(this.listClientes);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(1020, 619);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "CONSULTAR";
            this.tabConsultar.Enter += new System.EventHandler(this.tabConsultar_Enter);
            // 
            // txtBuscarClienteNombre
            // 
            this.txtBuscarClienteNombre.Depth = 0;
            this.txtBuscarClienteNombre.Hint = "Nombre";
            this.txtBuscarClienteNombre.Location = new System.Drawing.Point(208, 23);
            this.txtBuscarClienteNombre.MaxLength = 32767;
            this.txtBuscarClienteNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarClienteNombre.Name = "txtBuscarClienteNombre";
            this.txtBuscarClienteNombre.PasswordChar = '\0';
            this.txtBuscarClienteNombre.SelectedText = "";
            this.txtBuscarClienteNombre.SelectionLength = 0;
            this.txtBuscarClienteNombre.SelectionStart = 0;
            this.txtBuscarClienteNombre.Size = new System.Drawing.Size(210, 23);
            this.txtBuscarClienteNombre.TabIndex = 5;
            this.txtBuscarClienteNombre.TabStop = false;
            this.txtBuscarClienteNombre.UseSystemPasswordChar = false;
            this.txtBuscarClienteNombre.TextChanged += new System.EventHandler(this.txtBuscarClienteNombre_TextChanged);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Hint = "Apellido";
            this.txtBuscarCliente.Location = new System.Drawing.Point(451, 23);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(210, 23);
            this.txtBuscarCliente.TabIndex = 4;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // checkClientesEliminados
            // 
            this.checkClientesEliminados.AutoSize = true;
            this.checkClientesEliminados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkClientesEliminados.Depth = 0;
            this.checkClientesEliminados.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkClientesEliminados.Location = new System.Drawing.Point(9, 16);
            this.checkClientesEliminados.Margin = new System.Windows.Forms.Padding(0);
            this.checkClientesEliminados.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkClientesEliminados.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkClientesEliminados.Name = "checkClientesEliminados";
            this.checkClientesEliminados.Ripple = true;
            this.checkClientesEliminados.Size = new System.Drawing.Size(151, 30);
            this.checkClientesEliminados.TabIndex = 3;
            this.checkClientesEliminados.Text = "Clientes eliminados";
            this.checkClientesEliminados.UseVisualStyleBackColor = true;
            this.checkClientesEliminados.CheckedChanged += new System.EventHandler(this.checkClientesEliminados_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Icon = null;
            this.btnConsultar.Location = new System.Drawing.Point(916, 576);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(92, 36);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseCustomBackColor = false;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // listClientes
            // 
            this.listClientes.ContextMenuStrip = this.menuStrip;
            this.listClientes.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClientes.FullRowSelect = true;
            this.listClientes.GridLines = true;
            this.listClientes.Location = new System.Drawing.Point(9, 60);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(999, 507);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip.Depth = 0;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarItem,
            this.eliminarItem});
            this.menuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(118, 48);
            this.menuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.menuStrip_Opening);
            // 
            // editarItem
            // 
            this.editarItem.Name = "editarItem";
            this.editarItem.Size = new System.Drawing.Size(117, 22);
            this.editarItem.Text = "Editar";
            this.editarItem.Click += new System.EventHandler(this.editarItem_Click);
            // 
            // eliminarItem
            // 
            this.eliminarItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarItem.Image")));
            this.eliminarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarItem.Name = "eliminarItem";
            this.eliminarItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarItem.Text = "Eliminar";
            this.eliminarItem.Click += new System.EventHandler(this.eliminarItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // comboProvincias
            // 
            this.comboProvincias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(116, 423);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(121, 21);
            this.comboProvincias.TabIndex = 1;
            this.comboProvincias.SelectedValueChanged += new System.EventHandler(this.comboProvincias_SelectedValueChanged);
            // 
            // comboCiudades
            // 
            this.comboCiudades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudades.FormattingEnabled = true;
            this.comboCiudades.Location = new System.Drawing.Point(351, 423);
            this.comboCiudades.Name = "comboCiudades";
            this.comboCiudades.Size = new System.Drawing.Size(121, 21);
            this.comboCiudades.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Localidad";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.selectorClientes);
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.tabClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector selectorClientes;
        private MaterialSkin.Controls.MaterialTabControl tabClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCelular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroDoc;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialFlatButton txtRefrescar;
        private System.Windows.Forms.ListView listClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editarItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarItem;
        private MaterialSkin.Controls.MaterialCheckBox checkClientesEliminados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarClienteNombre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCiudades;
        private System.Windows.Forms.ComboBox comboProvincias;
    }
}