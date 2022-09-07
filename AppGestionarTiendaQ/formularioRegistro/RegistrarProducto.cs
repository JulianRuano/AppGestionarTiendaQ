using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
            LlenarCbxLote();
            LlenarCbxProveedor();
            LlenarCbxSucursal();
            cbxCodigoSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIdLote.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNitProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Producto prod = new Producto();
        #region btn
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtNitProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecioProducto.Text == "" || cbxCodigoSucursal.Text == "" || cbxEstado.Text == "" || cbxIdLote.Text == "" || cbxNitProveedor.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, resultado, nitProveedor, codigoSucursa, peso;
                string idLote, nombre, estado;
                double precio;
                codigo = int.Parse(txtNitProducto.Text);
                idLote = cbxIdLote.Text;
                nombre = txtNombreProducto.Text;
                peso = int.Parse(txtPesoProducto.Text);
                precio = double.Parse(txtPrecioProducto.Text);
                estado = cbxEstado.Text;
                nitProveedor = int.Parse(cbxNitProveedor.Text);
                codigoSucursa = int.Parse(cbxCodigoSucursal.Text);
                resultado = prod.ingresarProducto(codigo, idLote, nombre, peso, precio, estado, nitProveedor, codigoSucursa);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNitProducto.Text = "";
                txtNombreProducto.Text = "";
                txtPesoProducto.Text = "";
                txtPrecioProducto.Text = "";
                cbxCodigoSucursal.Text = null;
                cbxEstado.Text = null;
                cbxIdLote.Text = null;
                cbxNitProveedor.Text = null;


            }
        }
        #endregion

        #region llenarCbx
        private void LlenarCbxSucursal()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = prod.ConsultarCodigoSucursal();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxCodigoSucursal.Items.Add(dsResultado.Tables[0].Rows[i]["codigosucursal"].ToString());
            }
        }
        private void LlenarCbxLote()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = prod.ConsultarIdLote();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxIdLote.Items.Add(dsResultado.Tables[0].Rows[i]["idlote"].ToString());
            }
        }
        private void LlenarCbxProveedor()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = prod.ConsultarNitProveedor();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxNitProveedor.Items.Add(dsResultado.Tables[0].Rows[i]["nitproveedor"].ToString());
            }
        }
        #endregion

        #region keyPress
        private void txtNitProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
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
