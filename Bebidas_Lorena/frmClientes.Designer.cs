namespace Bebidas_Lorena
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
            this.panelBuscarAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.panelLineatxtUsuario = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.panelAgregarDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefonoC = new System.Windows.Forms.Label();
            this.lblDireccionC = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBuscarAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.panelAgregarDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuscarAgregar
            // 
            this.panelBuscarAgregar.BackColor = System.Drawing.Color.White;
            this.panelBuscarAgregar.Controls.Add(this.btnAgregar);
            this.panelBuscarAgregar.Controls.Add(this.picLupa);
            this.panelBuscarAgregar.Controls.Add(this.panelLineatxtUsuario);
            this.panelBuscarAgregar.Controls.Add(this.txtBuscar);
            this.panelBuscarAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscarAgregar.Location = new System.Drawing.Point(0, 38);
            this.panelBuscarAgregar.Name = "panelBuscarAgregar";
            this.panelBuscarAgregar.Size = new System.Drawing.Size(1200, 44);
            this.panelBuscarAgregar.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Brown;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1025, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picLupa
            // 
            this.picLupa.Image = global::Bebidas_Lorena.Properties.Resources.lupa;
            this.picLupa.Location = new System.Drawing.Point(263, 9);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(27, 27);
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLupa.TabIndex = 3;
            this.picLupa.TabStop = false;
            // 
            // panelLineatxtUsuario
            // 
            this.panelLineatxtUsuario.BackColor = System.Drawing.Color.Brown;
            this.panelLineatxtUsuario.Location = new System.Drawing.Point(12, 31);
            this.panelLineatxtUsuario.Name = "panelLineatxtUsuario";
            this.panelLineatxtUsuario.Size = new System.Drawing.Size(245, 1);
            this.panelLineatxtUsuario.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(12, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(245, 21);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Brown;
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(0, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(1200, 38);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostrar.Location = new System.Drawing.Point(0, 82);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.Size = new System.Drawing.Size(701, 645);
            this.dgvMostrar.TabIndex = 16;
            this.dgvMostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellDoubleClick);
            // 
            // panelAgregarDatos
            // 
            this.panelAgregarDatos.Controls.Add(this.panel1);
            this.panelAgregarDatos.Controls.Add(this.txtDireccion);
            this.panelAgregarDatos.Controls.Add(this.txtTelefono);
            this.panelAgregarDatos.Controls.Add(this.txtApellido);
            this.panelAgregarDatos.Controls.Add(this.lblTelefonoC);
            this.panelAgregarDatos.Controls.Add(this.lblDireccionC);
            this.panelAgregarDatos.Controls.Add(this.lblApellido);
            this.panelAgregarDatos.Controls.Add(this.txtNombre);
            this.panelAgregarDatos.Controls.Add(this.lblNombre);
            this.panelAgregarDatos.Controls.Add(this.lblRegistro);
            this.panelAgregarDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAgregarDatos.Location = new System.Drawing.Point(701, 82);
            this.panelAgregarDatos.Name = "panelAgregarDatos";
            this.panelAgregarDatos.Size = new System.Drawing.Size(499, 645);
            this.panelAgregarDatos.TabIndex = 15;
            this.panelAgregarDatos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 53);
            this.panel1.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Brown;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(21, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Brown;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(175, 12);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(144, 28);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Brown;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(329, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(144, 28);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 279);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(349, 28);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 233);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(349, 28);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 187);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(349, 28);
            this.txtApellido.TabIndex = 16;
            // 
            // lblTelefonoC
            // 
            this.lblTelefonoC.AutoSize = true;
            this.lblTelefonoC.Location = new System.Drawing.Point(12, 236);
            this.lblTelefonoC.Name = "lblTelefonoC";
            this.lblTelefonoC.Size = new System.Drawing.Size(73, 21);
            this.lblTelefonoC.TabIndex = 15;
            this.lblTelefonoC.Text = "Telefono:";
            // 
            // lblDireccionC
            // 
            this.lblDireccionC.AutoSize = true;
            this.lblDireccionC.Location = new System.Drawing.Point(12, 282);
            this.lblDireccionC.Name = "lblDireccionC";
            this.lblDireccionC.Size = new System.Drawing.Size(78, 21);
            this.lblDireccionC.TabIndex = 14;
            this.lblDireccionC.Text = "Direccion:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 190);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 21);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(349, 28);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.BackColor = System.Drawing.Color.Brown;
            this.lblRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(0, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(499, 35);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro de Clientes";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Bebidas_Lorena.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Bebidas_Lorena.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.panelAgregarDatos);
            this.Controls.Add(this.panelBuscarAgregar);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panelBuscarAgregar.ResumeLayout(false);
            this.panelBuscarAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.panelAgregarDatos.ResumeLayout(false);
            this.panelAgregarDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.Panel panelLineatxtUsuario;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Panel panelAgregarDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefonoC;
        private System.Windows.Forms.Label lblDireccionC;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}