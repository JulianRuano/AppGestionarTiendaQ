using System;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class RegistrarDescuento : Form
    {
        public RegistrarDescuento()
        {
            InitializeComponent();
        }

        Descuento des = new Descuento();

        #region btn
        private void btnGuardarDescuento_Click(object sender, EventArgs e)
        {
            if (txtCodigoDescuento.Text == "" || txtPorcentajeDescuento.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, porcentaje, resultado;
                porcentaje = int.Parse(txtPorcentajeDescuento.Text);
                if (porcentaje < 0 || porcentaje > 90)
                {
                    porcentaje = 90;  // EL maximo porcentaje aceptado sera del 90%
                }
                codigo = int.Parse(txtCodigoDescuento.Text);
                resultado = des.ingresarDescuento(codigo, porcentaje);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigoDescuento.Text = "";
                txtPorcentajeDescuento.Text = "";
            }
        }
        #endregion

        #region keyPrees
        private void txtCodigoDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPorcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
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
