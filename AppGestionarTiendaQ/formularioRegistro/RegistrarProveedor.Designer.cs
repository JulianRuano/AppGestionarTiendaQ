namespace appGestionarTiendaQ.formularioRegistro
{
    partial class RegistrarProveedor
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
            this.pnlRegistrarSucursal = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.lbcorreo = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNitProveedor = new System.Windows.Forms.TextBox();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbTituloSucursal = new System.Windows.Forms.Label();
            this.pnlRegistrarSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistrarSucursal
            // 
            this.pnlRegistrarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlRegistrarSucursal.Controls.Add(this.btnGuardar);
            this.pnlRegistrarSucursal.Controls.Add(this.txtCorreoProveedor);
            this.pnlRegistrarSucursal.Controls.Add(this.txtTelefonoProveedor);
            this.pnlRegistrarSucursal.Controls.Add(this.lbcorreo);
            this.pnlRegistrarSucursal.Controls.Add(this.lbTelefono);
            this.pnlRegistrarSucursal.Controls.Add(this.lbNombre);
            this.pnlRegistrarSucursal.Controls.Add(this.txtNombreProveedor);
            this.pnlRegistrarSucursal.Controls.Add(this.txtNitProveedor);
            this.pnlRegistrarSucursal.Controls.Add(this.lbNit);
            this.pnlRegistrarSucursal.Controls.Add(this.lbTituloSucursal);
            this.pnlRegistrarSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarSucursal.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarSucursal.Name = "pnlRegistrarSucursal";
            this.pnlRegistrarSucursal.Size = new System.Drawing.Size(800, 450);
            this.pnlRegistrarSucursal.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::appGestionarTiendaQ.Properties.Resources.disco_flexible;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(228, 319);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 46);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProveedor.Location = new System.Drawing.Point(228, 257);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(241, 21);
            this.txtCorreoProveedor.TabIndex = 12;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(228, 216);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(241, 21);
            this.txtTelefonoProveedor.TabIndex = 11;
            this.txtTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNitProveedor_KeyPress);
            // 
            // lbcorreo
            // 
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.ForeColor = System.Drawing.Color.White;
            this.lbcorreo.Location = new System.Drawing.Point(100, 257);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(70, 25);
            this.lbcorreo.TabIndex = 10;
            this.lbcorreo.Text = "Correo";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.White;
            this.lbTelefono.Location = new System.Drawing.Point(100, 216);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(84, 25);
            this.lbTelefono.TabIndex = 9;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(100, 177);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 25);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(228, 177);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(241, 21);
            this.txtNombreProveedor.TabIndex = 5;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // txtNitProveedor
            // 
            this.txtNitProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitProveedor.Location = new System.Drawing.Point(228, 134);
            this.txtNitProveedor.Name = "txtNitProveedor";
            this.txtNitProveedor.Size = new System.Drawing.Size(241, 21);
            this.txtNitProveedor.TabIndex = 4;
            this.txtNitProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNitProveedor_KeyPress);
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNit.ForeColor = System.Drawing.Color.White;
            this.lbNit.Location = new System.Drawing.Point(100, 134);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(37, 25);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "Nit";
            // 
            // lbTituloSucursal
            // 
            this.lbTituloSucursal.AutoSize = true;
            this.lbTituloSucursal.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbTituloSucursal.Location = new System.Drawing.Point(193, 53);
            this.lbTituloSucursal.Name = "lbTituloSucursal";
            this.lbTituloSucursal.Size = new System.Drawing.Size(215, 32);
            this.lbTituloSucursal.TabIndex = 0;
            this.lbTituloSucursal.Text = "Ingresar Proveedor";
            // 
            // RegistrarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegistrarSucursal);
            this.Name = "RegistrarProveedor";
            this.Text = "RegistrarProveedor";
            this.pnlRegistrarSucursal.ResumeLayout(false);
            this.pnlRegistrarSucursal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistrarSucursal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label lbcorreo;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNitProveedor;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.Label lbTituloSucursal;
    }
}