namespace appGestionarTiendaQ.formularioRegistro
{
    partial class RegistrarTipoProducto
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
            this.lnTituloTipoProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdTipoProducto = new System.Windows.Forms.Label();
            this.lbNombreTipoProducto = new System.Windows.Forms.Label();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.txtNombreTP = new System.Windows.Forms.TextBox();
            this.txtIdTP = new System.Windows.Forms.TextBox();
            this.pnlCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnTituloTipoProducto
            // 
            this.lnTituloTipoProducto.AutoSize = true;
            this.lnTituloTipoProducto.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTituloTipoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lnTituloTipoProducto.Location = new System.Drawing.Point(184, 55);
            this.lnTituloTipoProducto.Name = "lnTituloTipoProducto";
            this.lnTituloTipoProducto.Size = new System.Drawing.Size(143, 30);
            this.lnTituloTipoProducto.TabIndex = 0;
            this.lnTituloTipoProducto.Text = "Tipo Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lbIdTipoProducto
            // 
            this.lbIdTipoProducto.AutoSize = true;
            this.lbIdTipoProducto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdTipoProducto.ForeColor = System.Drawing.Color.White;
            this.lbIdTipoProducto.Location = new System.Drawing.Point(96, 132);
            this.lbIdTipoProducto.Name = "lbIdTipoProducto";
            this.lbIdTipoProducto.Size = new System.Drawing.Size(28, 25);
            this.lbIdTipoProducto.TabIndex = 2;
            this.lbIdTipoProducto.Text = "Id";
            // 
            // lbNombreTipoProducto
            // 
            this.lbNombreTipoProducto.AutoSize = true;
            this.lbNombreTipoProducto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreTipoProducto.ForeColor = System.Drawing.Color.White;
            this.lbNombreTipoProducto.Location = new System.Drawing.Point(98, 179);
            this.lbNombreTipoProducto.Name = "lbNombreTipoProducto";
            this.lbNombreTipoProducto.Size = new System.Drawing.Size(81, 25);
            this.lbNombreTipoProducto.TabIndex = 3;
            this.lbNombreTipoProducto.Text = "Nombre";
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAgregarCompra.FlatAppearance.BorderSize = 0;
            this.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.White;
           // this.btnAgregarCompra.Image = global::appGestionarTiendaQ.Properties.Resources.disco_flexible;
            this.btnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarCompra.Location = new System.Drawing.Point(207, 240);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(152, 46);
            this.btnAgregarCompra.TabIndex = 29;
            this.btnAgregarCompra.Text = "Guardar";
            this.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // pnlCompra
            // 
            this.pnlCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlCompra.Controls.Add(this.txtNombreTP);
            this.pnlCompra.Controls.Add(this.txtIdTP);
            this.pnlCompra.Controls.Add(this.btnAgregarCompra);
            this.pnlCompra.Controls.Add(this.lbNombreTipoProducto);
            this.pnlCompra.Controls.Add(this.lbIdTipoProducto);
            this.pnlCompra.Controls.Add(this.label1);
            this.pnlCompra.Controls.Add(this.lnTituloTipoProducto);
            this.pnlCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompra.Location = new System.Drawing.Point(0, 0);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(800, 450);
            this.pnlCompra.TabIndex = 1;
            // 
            // txtNombreTP
            // 
            this.txtNombreTP.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTP.Location = new System.Drawing.Point(207, 181);
            this.txtNombreTP.Name = "txtNombreTP";
            this.txtNombreTP.Size = new System.Drawing.Size(257, 23);
            this.txtNombreTP.TabIndex = 31;
            this.txtNombreTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTP_KeyPress);
            // 
            // txtIdTP
            // 
            this.txtIdTP.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTP.Location = new System.Drawing.Point(207, 132);
            this.txtIdTP.Name = "txtIdTP";
            this.txtIdTP.Size = new System.Drawing.Size(257, 23);
            this.txtIdTP.TabIndex = 30;
            this.txtIdTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTP_KeyPress);
            // 
            // RegistrarTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCompra);
            this.Name = "RegistrarTipoProducto";
            this.Text = "RegistrarTipoProducto";
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lnTituloTipoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdTipoProducto;
        private System.Windows.Forms.Label lbNombreTipoProducto;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.TextBox txtNombreTP;
        private System.Windows.Forms.TextBox txtIdTP;
    }
}