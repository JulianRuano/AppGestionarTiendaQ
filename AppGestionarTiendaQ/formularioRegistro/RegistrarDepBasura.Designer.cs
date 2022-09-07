namespace appGestionarTienda.formularioRegistro
{
    partial class RegistrarDepBasura
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
            this.pnlDepBasura = new System.Windows.Forms.Panel();
            this.btnGuardarAsistente = new System.Windows.Forms.Button();
            this.cbxTipoBasura = new System.Windows.Forms.ComboBox();
            this.cbxNitProductoDeposito = new System.Windows.Forms.ComboBox();
            this.txtCodigoDeposito = new System.Windows.Forms.TextBox();
            this.lbCodigoBasura = new System.Windows.Forms.Label();
            this.lbTipoBasura = new System.Windows.Forms.Label();
            this.lbNitProducto = new System.Windows.Forms.Label();
            this.lbTituloDescuento = new System.Windows.Forms.Label();
            this.pnlDepBasura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDepBasura
            // 
            this.pnlDepBasura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlDepBasura.Controls.Add(this.btnGuardarAsistente);
            this.pnlDepBasura.Controls.Add(this.cbxTipoBasura);
            this.pnlDepBasura.Controls.Add(this.cbxNitProductoDeposito);
            this.pnlDepBasura.Controls.Add(this.txtCodigoDeposito);
            this.pnlDepBasura.Controls.Add(this.lbCodigoBasura);
            this.pnlDepBasura.Controls.Add(this.lbTipoBasura);
            this.pnlDepBasura.Controls.Add(this.lbNitProducto);
            this.pnlDepBasura.Controls.Add(this.lbTituloDescuento);
            this.pnlDepBasura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepBasura.Location = new System.Drawing.Point(0, 0);
            this.pnlDepBasura.Name = "pnlDepBasura";
            this.pnlDepBasura.Size = new System.Drawing.Size(733, 499);
            this.pnlDepBasura.TabIndex = 0;
            // 
            // btnGuardarAsistente
            // 
            this.btnGuardarAsistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnGuardarAsistente.FlatAppearance.BorderSize = 0;
            this.btnGuardarAsistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsistente.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsistente.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAsistente.Image = global::appGestionarTiendaQ.Properties.Resources.disco_flexible;
            this.btnGuardarAsistente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarAsistente.Location = new System.Drawing.Point(269, 300);
            this.btnGuardarAsistente.Name = "btnGuardarAsistente";
            this.btnGuardarAsistente.Size = new System.Drawing.Size(152, 46);
            this.btnGuardarAsistente.TabIndex = 21;
            this.btnGuardarAsistente.Text = "Guardar";
            this.btnGuardarAsistente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsistente.UseVisualStyleBackColor = false;
            this.btnGuardarAsistente.Click += new System.EventHandler(this.btnDepositoBasura_Click);
            // 
            // cbxTipoBasura
            // 
            this.cbxTipoBasura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoBasura.FormattingEnabled = true;
            this.cbxTipoBasura.Items.AddRange(new object[] {
            "ORGANICA",
            "INORGANICA"});
            this.cbxTipoBasura.Location = new System.Drawing.Point(269, 233);
            this.cbxTipoBasura.Name = "cbxTipoBasura";
            this.cbxTipoBasura.Size = new System.Drawing.Size(217, 23);
            this.cbxTipoBasura.TabIndex = 9;
            // 
            // cbxNitProductoDeposito
            // 
            this.cbxNitProductoDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNitProductoDeposito.FormattingEnabled = true;
            this.cbxNitProductoDeposito.Location = new System.Drawing.Point(269, 191);
            this.cbxNitProductoDeposito.Name = "cbxNitProductoDeposito";
            this.cbxNitProductoDeposito.Size = new System.Drawing.Size(217, 23);
            this.cbxNitProductoDeposito.TabIndex = 8;
            // 
            // txtCodigoDeposito
            // 
            this.txtCodigoDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeposito.Location = new System.Drawing.Point(269, 154);
            this.txtCodigoDeposito.Name = "txtCodigoDeposito";
            this.txtCodigoDeposito.Size = new System.Drawing.Size(217, 21);
            this.txtCodigoDeposito.TabIndex = 7;
            this.txtCodigoDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeposito_KeyPress);
            // 
            // lbCodigoBasura
            // 
            this.lbCodigoBasura.AutoSize = true;
            this.lbCodigoBasura.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBasura.ForeColor = System.Drawing.Color.White;
            this.lbCodigoBasura.Location = new System.Drawing.Point(131, 154);
            this.lbCodigoBasura.Name = "lbCodigoBasura";
            this.lbCodigoBasura.Size = new System.Drawing.Size(73, 25);
            this.lbCodigoBasura.TabIndex = 5;
            this.lbCodigoBasura.Text = "Codigo";
            // 
            // lbTipoBasura
            // 
            this.lbTipoBasura.AutoSize = true;
            this.lbTipoBasura.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoBasura.ForeColor = System.Drawing.Color.White;
            this.lbTipoBasura.Location = new System.Drawing.Point(131, 233);
            this.lbTipoBasura.Name = "lbTipoBasura";
            this.lbTipoBasura.Size = new System.Drawing.Size(111, 25);
            this.lbTipoBasura.TabIndex = 4;
            this.lbTipoBasura.Text = "Tipo Basura";
            // 
            // lbNitProducto
            // 
            this.lbNitProducto.AutoSize = true;
            this.lbNitProducto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNitProducto.ForeColor = System.Drawing.Color.White;
            this.lbNitProducto.Location = new System.Drawing.Point(133, 191);
            this.lbNitProducto.Name = "lbNitProducto";
            this.lbNitProducto.Size = new System.Drawing.Size(119, 25);
            this.lbNitProducto.TabIndex = 3;
            this.lbNitProducto.Text = "Nit Producto";
            // 
            // lbTituloDescuento
            // 
            this.lbTituloDescuento.AutoSize = true;
            this.lbTituloDescuento.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbTituloDescuento.Location = new System.Drawing.Point(160, 82);
            this.lbTituloDescuento.Name = "lbTituloDescuento";
            this.lbTituloDescuento.Size = new System.Drawing.Size(346, 32);
            this.lbTituloDescuento.TabIndex = 0;
            this.lbTituloDescuento.Text = "Registra los Datos del Deposito";
            // 
            // RegistrarDepBasura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.pnlDepBasura);
            this.Name = "RegistrarDepBasura";
            this.Text = "RegistrarDepBasura";
            this.pnlDepBasura.ResumeLayout(false);
            this.pnlDepBasura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepBasura;
        private System.Windows.Forms.Label lbCodigoBasura;
        private System.Windows.Forms.Label lbTipoBasura;
        private System.Windows.Forms.Label lbNitProducto;
        private System.Windows.Forms.Label lbTituloDescuento;
        private System.Windows.Forms.TextBox txtCodigoDeposito;
        private System.Windows.Forms.ComboBox cbxTipoBasura;
        private System.Windows.Forms.ComboBox cbxNitProductoDeposito;
        private System.Windows.Forms.Button btnGuardarAsistente;
    }
}