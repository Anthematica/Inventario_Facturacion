namespace Bebidas_Lorena
{
    partial class frmProveedor
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.panelAgregarDatos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblTelefonoP = new System.Windows.Forms.Label();
            this.lblDireccionE = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
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
            this.panelBuscarAgregar.Controls.Add(this.btnAgregar);
            this.panelBuscarAgregar.Controls.Add(this.picLupa);
            this.panelBuscarAgregar.Controls.Add(this.panelLineatxtUsuario);
            this.panelBuscarAgregar.Controls.Add(this.txtBuscar);
            this.panelBuscarAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscarAgregar.Location = new System.Drawing.Point(0, 38);
            this.panelBuscarAgregar.Name = "panelBuscarAgregar";
            this.panelBuscarAgregar.Size = new System.Drawing.Size(1200, 44);
            this.panelBuscarAgregar.TabIndex = 7;
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
            this.picLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // lblProveedor
            // 
            this.lblProveedor.BackColor = System.Drawing.Color.Brown;
            this.lblProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(0, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(1200, 38);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvMostrar.TabIndex = 11;
            this.dgvMostrar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellDoubleClick);
            // 
            // panelAgregarDatos
            // 
            this.panelAgregarDatos.Controls.Add(this.panel1);
            this.panelAgregarDatos.Controls.Add(this.txtTelefonoProveedor);
            this.panelAgregarDatos.Controls.Add(this.txtDireccionEmpresa);
            this.panelAgregarDatos.Controls.Add(this.txtNombreProveedor);
            this.panelAgregarDatos.Controls.Add(this.lblTelefonoP);
            this.panelAgregarDatos.Controls.Add(this.lblDireccionE);
            this.panelAgregarDatos.Controls.Add(this.lblNombreProveedor);
            this.panelAgregarDatos.Controls.Add(this.txtNombreEmpresa);
            this.panelAgregarDatos.Controls.Add(this.lblNombreEmpresa);
            this.panelAgregarDatos.Controls.Add(this.lblRegistro);
            this.panelAgregarDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAgregarDatos.Location = new System.Drawing.Point(701, 82);
            this.panelAgregarDatos.Name = "panelAgregarDatos";
            this.panelAgregarDatos.Size = new System.Drawing.Size(499, 645);
            this.panelAgregarDatos.TabIndex = 10;
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
            this.panel1.TabIndex = 22;
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
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(183, 284);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(303, 28);
            this.txtTelefonoProveedor.TabIndex = 18;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(183, 238);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(303, 28);
            this.txtDireccionEmpresa.TabIndex = 17;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(183, 192);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(303, 28);
            this.txtNombreProveedor.TabIndex = 16;
            // 
            // lblTelefonoP
            // 
            this.lblTelefonoP.AutoSize = true;
            this.lblTelefonoP.Location = new System.Drawing.Point(17, 287);
            this.lblTelefonoP.Name = "lblTelefonoP";
            this.lblTelefonoP.Size = new System.Drawing.Size(149, 21);
            this.lblTelefonoP.TabIndex = 15;
            this.lblTelefonoP.Text = "Telefono proveedor:";
            // 
            // lblDireccionE
            // 
            this.lblDireccionE.AutoSize = true;
            this.lblDireccionE.Location = new System.Drawing.Point(17, 241);
            this.lblDireccionE.Name = "lblDireccionE";
            this.lblDireccionE.Size = new System.Drawing.Size(142, 21);
            this.lblDireccionE.TabIndex = 14;
            this.lblDireccionE.Text = "Direccion empresa:";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 195);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(172, 21);
            this.lblNombreProveedor.TabIndex = 13;
            this.lblNombreProveedor.Text = "Nombre del proveedor:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(183, 146);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(303, 28);
            this.txtNombreEmpresa.TabIndex = 12;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(12, 149);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(172, 21);
            this.lblNombreEmpresa.TabIndex = 11;
            this.lblNombreEmpresa.Text = "Nombre de la empresa:";
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
            this.lblRegistro.Text = "Registro de proveedores";
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
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.panelAgregarDatos);
            this.Controls.Add(this.panelBuscarAgregar);
            this.Controls.Add(this.lblProveedor);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProveedor_Load);
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
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelAgregarDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblTelefonoP;
        private System.Windows.Forms.Label lblDireccionE;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblRegistro;
    }
}