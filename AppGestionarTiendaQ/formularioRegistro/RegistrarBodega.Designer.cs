namespace appGestionarTienda.formularioRegistro
{
    partial class RegistrarBodega
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
            this.pnlBodega = new System.Windows.Forms.Panel();
            this.btnGuardarBodega = new System.Windows.Forms.Button();
            this.cbxIdEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombreBodega = new System.Windows.Forms.TextBox();
            this.txtCodigoBodega = new System.Windows.Forms.TextBox();
            this.lbIdEmpleado = new System.Windows.Forms.Label();
            this.lbNombreBodega = new System.Windows.Forms.Label();
            this.lbCodigoBodega = new System.Windows.Forms.Label();
            this.lblTituloBodega = new System.Windows.Forms.Label();
            this.pnlBodega.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBodega
            // 
            this.pnlBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.pnlBodega.Controls.Add(this.btnGuardarBodega);
            this.pnlBodega.Controls.Add(this.cbxIdEmpleado);
            this.pnlBodega.Controls.Add(this.txtNombreBodega);
            this.pnlBodega.Controls.Add(this.txtCodigoBodega);
            this.pnlBodega.Controls.Add(this.lbIdEmpleado);
            this.pnlBodega.Controls.Add(this.lbNombreBodega);
            this.pnlBodega.Controls.Add(this.lbCodigoBodega);
            this.pnlBodega.Controls.Add(this.lblTituloBodega);
            this.pnlBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodega.Location = new System.Drawing.Point(0, 0);
            this.pnlBodega.Name = "pnlBodega";
            this.pnlBodega.Size = new System.Drawing.Size(733, 499);
            this.pnlBodega.TabIndex = 0;
            // 
            // btnGuardarBodega
            // 
            this.btnGuardarBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnGuardarBodega.FlatAppearance.BorderSize = 0;
            this.btnGuardarBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarBodega.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBodega.ForeColor = System.Drawing.Color.White;
            this.btnGuardarBodega.Image = global::appGestionarTiendaQ.Properties.Resources.disco_flexible;
            this.btnGuardarBodega.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarBodega.Location = new System.Drawing.Point(259, 289);
            this.btnGuardarBodega.Name = "btnGuardarBodega";
            this.btnGuardarBodega.Size = new System.Drawing.Size(152, 46);
            this.btnGuardarBodega.TabIndex = 21;
            this.btnGuardarBodega.Text = "Guardar";
            this.btnGuardarBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarBodega.UseVisualStyleBackColor = false;
            this.btnGuardarBodega.Click += new System.EventHandler(this.btnGuardarBodega_Click_1);
            // 
            // cbxIdEmpleado
            // 
            this.cbxIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdEmpleado.FormattingEnabled = true;
            this.cbxIdEmpleado.Location = new System.Drawing.Point(259, 231);
            this.cbxIdEmpleado.Name = "cbxIdEmpleado";
            this.cbxIdEmpleado.Size = new System.Drawing.Size(210, 23);
            this.cbxIdEmpleado.TabIndex = 6;
            // 
            // txtNombreBodega
            // 
            this.txtNombreBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBodega.Location = new System.Drawing.Point(259, 192);
            this.txtNombreBodega.Name = "txtNombreBodega";
            this.txtNombreBodega.Size = new System.Drawing.Size(210, 21);
            this.txtNombreBodega.TabIndex = 5;
            this.txtNombreBodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreBodega_KeyPress);
            // 
            // txtCodigoBodega
            // 
            this.txtCodigoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBodega.Location = new System.Drawing.Point(259, 152);
            this.txtCodigoBodega.Name = "txtCodigoBodega";
            this.txtCodigoBodega.Size = new System.Drawing.Size(210, 21);
            this.txtCodigoBodega.TabIndex = 4;
            this.txtCodigoBodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBodega_KeyPress);
            // 
            // lbIdEmpleado
            // 
            this.lbIdEmpleado.AutoSize = true;
            this.lbIdEmpleado.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdEmpleado.ForeColor = System.Drawing.Color.White;
            this.lbIdEmpleado.Location = new System.Drawing.Point(127, 234);
            this.lbIdEmpleado.Name = "lbIdEmpleado";
            this.lbIdEmpleado.Size = new System.Drawing.Size(117, 25);
            this.lbIdEmpleado.TabIndex = 3;
            this.lbIdEmpleado.Text = "Id Empleado";
            // 
            // lbNombreBodega
            // 
            this.lbNombreBodega.AutoSize = true;
            this.lbNombreBodega.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreBodega.ForeColor = System.Drawing.Color.White;
            this.lbNombreBodega.Location = new System.Drawing.Point(127, 194);
            this.lbNombreBodega.Name = "lbNombreBodega";
            this.lbNombreBodega.Size = new System.Drawing.Size(81, 25);
            this.lbNombreBodega.TabIndex = 2;
            this.lbNombreBodega.Text = "Nombre";
            // 
            // lbCodigoBodega
            // 
            this.lbCodigoBodega.AutoSize = true;
            this.lbCodigoBodega.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBodega.ForeColor = System.Drawing.Color.White;
            this.lbCodigoBodega.Location = new System.Drawing.Point(127, 154);
            this.lbCodigoBodega.Name = "lbCodigoBodega";
            this.lbCodigoBodega.Size = new System.Drawing.Size(73, 25);
            this.lbCodigoBodega.TabIndex = 1;
            this.lbCodigoBodega.Text = "Codigo";
            // 
            // lblTituloBodega
            // 
            this.lblTituloBodega.AutoSize = true;
            this.lblTituloBodega.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBodega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTituloBodega.Location = new System.Drawing.Point(229, 67);
            this.lblTituloBodega.Name = "lblTituloBodega";
            this.lblTituloBodega.Size = new System.Drawing.Size(194, 32);
            this.lblTituloBodega.TabIndex = 0;
            this.lblTituloBodega.Text = "Registrar Bodega";
            // 
            // RegistrarBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.pnlBodega);
            this.Name = "RegistrarBodega";
            this.Text = "RegistrarBodega";
            this.pnlBodega.ResumeLayout(false);
            this.pnlBodega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBodega;
        private System.Windows.Forms.Label lbIdEmpleado;
        private System.Windows.Forms.Label lbNombreBodega;
        private System.Windows.Forms.Label lbCodigoBodega;
        private System.Windows.Forms.Label lblTituloBodega;
        private System.Windows.Forms.ComboBox cbxIdEmpleado;
        private System.Windows.Forms.TextBox txtNombreBodega;
        private System.Windows.Forms.TextBox txtCodigoBodega;
        private System.Windows.Forms.Button btnGuardarBodega;
    }
}