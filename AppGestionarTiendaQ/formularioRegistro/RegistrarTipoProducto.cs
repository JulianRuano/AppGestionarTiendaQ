using System;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class RegistrarTipoProducto : Form
    {
        public RegistrarTipoProducto()
        {
            InitializeComponent();
        }

        TipoProducto objTipoProducto = new TipoProducto();

        #region btn
        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            if (txtIdTP.Text == "" || txtNombreTP.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Capturo en variables lo que el usuario escribio de la interfaz 
                int id, resultado;
                string nombre;
                id = int.Parse(txtIdTP.Text);
                nombre = txtNombreTP.Text;
                //Envio las variables a la capa de la logica
                resultado = objTipoProducto.RegistrarTipoProducto(id, nombre);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtIdTP.Text = "";
                txtNombreTP.Text = "";
            }
        }
        #endregion

        #region keyPress
        private void txtIdTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion


    }
}
