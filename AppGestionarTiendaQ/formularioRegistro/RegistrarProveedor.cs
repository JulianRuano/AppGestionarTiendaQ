using System;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class RegistrarProveedor : Form
    {
        public RegistrarProveedor()
        {
            InitializeComponent();
        }
        Proveedor prov = new Proveedor();

        #region btn
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNitProveedor.Text == "" || txtNombreProveedor.Text == "" || txtTelefonoProveedor.Text == "" || txtCorreoProveedor.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, resultado;
                double telefono;
                string nombre, correo;
                codigo = int.Parse(txtNitProveedor.Text);
                nombre = txtNombreProveedor.Text;
                telefono = double.Parse(txtTelefonoProveedor.Text);
                correo = txtCorreoProveedor.Text;
                resultado = prov.ingresarProveedor(codigo, nombre, telefono, correo);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNitProveedor.Text = "";
                txtNombreProveedor.Text = "";
                txtTelefonoProveedor.Text = "";
                txtCorreoProveedor.Text = "";
            }
        }


        #endregion

        #region keyPress
        private void txtNitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
