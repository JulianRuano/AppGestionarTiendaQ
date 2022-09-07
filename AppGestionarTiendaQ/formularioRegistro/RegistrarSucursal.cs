using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro
{
    public partial class RegistrarSucursal : Form
    {
        public RegistrarSucursal()
        {
            InitializeComponent();
            llenarCbxEmpleado();
            cbxIdEmpleadoSucursal.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        Sucursal suc = new Sucursal();

        #region btn
        private void btnGuardarSucursal_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoSucursal.Text == "" || txtDireccionSucursal.Text == "" || txtNombreSucursal.Text == "" || txtTelefonoSucursal.Text == "" || cbxIdEmpleadoSucursal.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, codigoEmpleado, resultado;
                string nombre, direccion;
                double telefono;

                codigo = int.Parse(txtCodigoSucursal.Text);
                nombre = txtNombreSucursal.Text;
                direccion = txtDireccionSucursal.Text;
                telefono = double.Parse(txtTelefonoSucursal.Text);
                codigoEmpleado = int.Parse(cbxIdEmpleadoSucursal.Text);

                resultado = suc.ingresarSucursal(codigo, nombre, direccion, telefono, codigoEmpleado);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigoSucursal.Text = "";
                txtNombreSucursal.Text = "";
                txtDireccionSucursal.Text = "";
                txtTelefonoSucursal.Text = "";
            }
        }
        #endregion

        #region llenasCbx
        private void llenarCbxEmpleado()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = suc.ConsultarIdEmpleado();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxIdEmpleadoSucursal.Items.Add(dsResultado.Tables[0].Rows[i]["idempleado"].ToString());
            }
        }
        #endregion

        #region keyPress
        private void txtCodigoSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoSucursal_KeyPress(object sender, KeyPressEventArgs e)
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

