using System;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro { 
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }      
        Cliente cli = new Cliente();

        #region btn
        private void btnGuardarCliente_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == "" || txtCorreoCliente.Text == "" || txtDireccionCliente.Text == "" || txtNombreCliente.Text == "" || txtPrimerApellidoC.Text == "" || txtTelefonoCliente.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, resultado;
                string nombre, primerApellido, segundoApellido, correo, direccion;
                double telefono;
                codigo = int.Parse(txtCodigoCliente.Text);
                nombre = txtNombreCliente.Text;
                primerApellido = txtPrimerApellidoC.Text;
                segundoApellido = txtSegundoApellidoC.Text;
                telefono = double.Parse(txtTelefonoCliente.Text);
                correo = txtCorreoCliente.Text;
                direccion = txtDireccionCliente.Text;
                resultado = cli.registrarCliente(codigo, nombre, primerApellido, segundoApellido, telefono, correo, direccion);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigoCliente.Text = "";
                txtNombreCliente.Text = "";
                txtPrimerApellidoC.Text = "";
                txtSegundoApellidoC.Text = "";
                txtTelefonoCliente.Text = "";
                txtCorreoCliente.Text = "";
                txtDireccionCliente.Text = "";

            }
        }
            #endregion

        #region keyPrees

            private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerApellidoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoApellidoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        
    }
}
