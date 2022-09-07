namespace appGestionarTiendaQ.formularioRegistro
{
    partial class SeAlmacena
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
            this.calendarFechaSeAlmacena = new System.Windows.Forms.DateTimePicker();
            this.cbxNitProducto = new System.Windows.Forms.ComboBox();
            this.cbxCodigoBodega = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbNitProducto = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnlRegistrarSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistrarSucursal
            // 
            this.pnlRegistrarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlRegistrarSucursal.Controls.Add(this.calendarFechaSeAlmacena);
            this.pnlRegistrarSucursal.Controls.Add(this.cbxNitProducto);
            this.pnlRegistrarSucursal.Controls.Add(this.cbxCodigoBodega);
            this.pnlRegistrarSucursal.Controls.Add(this.btnGuardar);
            this.pnlRegistrarSucursal.Controls.Add(this.lbFecha);
            this.pnlRegistrarSucursal.Controls.Add(this.lbNitProducto);
            this.pnlRegistrarSucursal.Controls.Add(this.lbCodigo);
            this.pnlRegistrarSucursal.Controls.Add(this.lbTitulo);
            this.pnlRegistrarSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarSucursal.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarSucursal.Name = "pnlRegistrarSucursal";
            this.pnlRegistrarSucursal.Size = new System.Drawing.Size(800, 450);
            this.pnlRegistrarSucursal.TabIndex = 2;
            // 
            // calendarFechaSeAlmacena
            // 
            this.calendarFechaSeAlmacena.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarFechaSeAlmacena.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarFechaSeAlmacena.Location = new System.Drawing.Point(253, 216);
            this.calendarFechaSeAlmacena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarFechaSeAlmacena.Name = "calendarFechaSeAlmacena";
            this.calendarFechaSeAlmacena.Size = new System.Drawing.Size(99, 23);
            this.calendarFechaSeAlmacena.TabIndex = 56;
            // 
            // cbxNitProducto
            // 
            this.cbxNitProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNitProducto.FormattingEnabled = true;
            this.cbxNitProducto.Location = new System.Drawing.Point(253, 165);
            this.cbxNitProducto.Name = "cbxNitProducto";
            this.cbxNitProducto.Size = new System.Drawing.Size(241, 23);
            this.cbxNitProducto.TabIndex = 54;
            // 
            // cbxCodigoBodega
            // 
            this.cbxCodigoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCodigoBodega.FormattingEnabled = true;
            this.cbxCodigoBodega.Location = new System.Drawing.Point(253, 122);
            this.cbxCodigoBodega.Name = "cbxCodigoBodega";
            this.cbxCodigoBodega.Size = new System.Drawing.Size(241, 23);
            this.cbxCodigoBodega.TabIndex = 53;
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
            this.btnGuardar.Location = new System.Drawing.Point(253, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 46);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(105, 214);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(61, 25);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "Fecha";
            // 
            // lbNitProducto
            // 
            this.lbNitProducto.AutoSize = true;
            this.lbNitProducto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNitProducto.ForeColor = System.Drawing.Color.White;
            this.lbNitProducto.Location = new System.Drawing.Point(105, 163);
            this.lbNitProducto.Name = "lbNitProducto";
            this.lbNitProducto.Size = new System.Drawing.Size(119, 25);
            this.lbNitProducto.TabIndex = 8;
            this.lbNitProducto.Text = "Nit Producto";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(105, 120);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(142, 25);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo Bodega";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbTitulo.Location = new System.Drawing.Point(198, 39);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(239, 32);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Almacenar Productos";
            // 
            // SeAlmacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegistrarSucursal);
            this.Name = "SeAlmacena";
            this.Text = "SeAlmacena";
            this.pnlRegistrarSucursal.ResumeLayout(false);
            this.pnlRegistrarSucursal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistrarSucursal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbNitProducto;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbxCodigoBodega;
        private System.Windows.Forms.ComboBox cbxNitProducto;
        private System.Windows.Forms.DateTimePicker calendarFechaSeAlmacena;
    }
}