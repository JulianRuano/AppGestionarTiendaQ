namespace appGestionarTiendaQ.formularioRegistro
{
    partial class RegistrarDescuento
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.txtCodigoDescuento = new System.Windows.Forms.TextBox();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.lbDesCodigo = new System.Windows.Forms.Label();
            this.lbDecCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnTituloIngresarDescuento = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlBackground.Controls.Add(this.txtPorcentajeDescuento);
            this.pnlBackground.Controls.Add(this.txtCodigoDescuento);
            this.pnlBackground.Controls.Add(this.btnAgregarCompra);
            this.pnlBackground.Controls.Add(this.lbDesCodigo);
            this.pnlBackground.Controls.Add(this.lbDecCodigo);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.lnTituloIngresarDescuento);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 450);
            this.pnlBackground.TabIndex = 2;
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(210, 189);
            this.txtPorcentajeDescuento.MaxLength = 100;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(257, 23);
            this.txtPorcentajeDescuento.TabIndex = 31;
            this.txtPorcentajeDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeDescuento_KeyPress);
            // 
            // txtCodigoDescuento
            // 
            this.txtCodigoDescuento.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDescuento.Location = new System.Drawing.Point(210, 140);
            this.txtCodigoDescuento.Name = "txtCodigoDescuento";
            this.txtCodigoDescuento.Size = new System.Drawing.Size(257, 23);
            this.txtCodigoDescuento.TabIndex = 30;
            this.txtCodigoDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDescuento_KeyPress);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAgregarCompra.FlatAppearance.BorderSize = 0;
            this.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCompra.Image = global::appGestionarTiendaQ.Properties.Resources.disco_flexible;
            this.btnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarCompra.Location = new System.Drawing.Point(210, 253);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(152, 46);
            this.btnAgregarCompra.TabIndex = 29;
            this.btnAgregarCompra.Text = "Guardar";
            this.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnGuardarDescuento_Click);
            // 
            // lbDesCodigo
            // 
            this.lbDesCodigo.AutoSize = true;
            this.lbDesCodigo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesCodigo.ForeColor = System.Drawing.Color.White;
            this.lbDesCodigo.Location = new System.Drawing.Point(101, 187);
            this.lbDesCodigo.Name = "lbDesCodigo";
            this.lbDesCodigo.Size = new System.Drawing.Size(101, 25);
            this.lbDesCodigo.TabIndex = 3;
            this.lbDesCodigo.Text = "Porcentaje";
            // 
            // lbDecCodigo
            // 
            this.lbDecCodigo.AutoSize = true;
            this.lbDecCodigo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecCodigo.ForeColor = System.Drawing.Color.White;
            this.lbDecCodigo.Location = new System.Drawing.Point(99, 140);
            this.lbDecCodigo.Name = "lbDecCodigo";
            this.lbDecCodigo.Size = new System.Drawing.Size(73, 25);
            this.lbDecCodigo.TabIndex = 2;
            this.lbDecCodigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lnTituloIngresarDescuento
            // 
            this.lnTituloIngresarDescuento.AutoSize = true;
            this.lnTituloIngresarDescuento.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTituloIngresarDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lnTituloIngresarDescuento.Location = new System.Drawing.Point(187, 63);
            this.lnTituloIngresarDescuento.Name = "lnTituloIngresarDescuento";
            this.lnTituloIngresarDescuento.Size = new System.Drawing.Size(193, 30);
            this.lnTituloIngresarDescuento.TabIndex = 0;
            this.lnTituloIngresarDescuento.Text = "Ingresar Descuento";
            // 
            // RegistrarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBackground);
            this.Name = "RegistrarDescuento";
            this.Text = "RegistrarDescuento";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.TextBox txtCodigoDescuento;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Label lbDesCodigo;
        private System.Windows.Forms.Label lbDecCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnTituloIngresarDescuento;
    }
}