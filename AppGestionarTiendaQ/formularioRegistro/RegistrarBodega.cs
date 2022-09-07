using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro
{
    public partial class RegistrarBodega : Form
    {
        public RegistrarBodega()
        {
            InitializeComponent();
            llenarCbxEmpleado();
            cbxIdEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;           
        }

        Bodega bodega = new Bodega();

        #region btn
        private void btnGuardarBodega_Click_1(object sender, EventArgs e)
        {
            if (cbxIdEmpleado.Text == "" || txtCodigoBodega.Text == "" || txtNombreBodega.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, idempleado, resultado;
                string nombre;
                codigo = int.Parse(txtCodigoBodega.Text);
                nombre = txtNombreBodega.Text;
                idempleado = int.Parse(cbxIdEmpleado.Text);
                resultado = bodega.ingresarBodega(codigo, nombre, idempleado);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigoBodega.Text = "";
                txtNombreBodega.Text = "";
                cbxIdEmpleado.Text = null;
            }
        }
        #endregion

        #region llenarCbx
        private void llenarCbxEmpleado()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = bodega.ConsultarIdEmpleado();
        

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxIdEmpleado.Items.Add(dsResultado.Tables[0].Rows[i]["idempleado"].ToString());
            }
        }
        #endregion

        #region keyPress
        private void txtCodigoBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

       
    }
}
