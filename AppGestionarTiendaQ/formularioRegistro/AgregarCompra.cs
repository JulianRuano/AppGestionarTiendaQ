using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro
{
    public partial class AgregarCompra : Form
    {
        public AgregarCompra()
        {
            InitializeComponent();
            llenarCbxNitProducto();
            llenarCbxCliente();
            llenarCbxCodigoDescuento();
            llenarCbxIdEmpleado();
            cbxCodigoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNitProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCodigoDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIdEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Compra com = new Compra();

        #region btn
        private void btnAgregarCompra_Click_1(object sender, EventArgs e)
        {
            if (cbxCodigoCliente.Text == "" || cbxNitProducto.Text == "" || cbxTipoPago.Text == "" || cbxIdEmpleado.Text == "" || cbxCodigoDescuento.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, nitProducto, resultado, idEmpleado, codigoDecuento;
                string fecha, tipoPago;
                codigo = int.Parse(cbxCodigoCliente.Text);
                nitProducto = int.Parse(cbxNitProducto.Text);
                fecha = calendarFechaCompra.Text;
                tipoPago = cbxTipoPago.Text;
                codigoDecuento = int.Parse(cbxCodigoDescuento.Text);
                idEmpleado = int.Parse(cbxIdEmpleado.Text);
                resultado = com.AgregarCompra(codigo, nitProducto, fecha, tipoPago, codigoDecuento, idEmpleado);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cbxCodigoCliente.Text = null;
                cbxCodigoDescuento.Text = null;
                cbxIdEmpleado.Text = null;
                cbxNitProducto.Text = null;
                cbxTipoPago.Text = null;

            }
        }
        #endregion

        #region llenarCbx
        private void llenarCbxCliente()
        {            
            DataSet dsResultado = new DataSet();
            dsResultado = com.ConsultarCodigoCliente();
            
            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxCodigoCliente.Items.Add(dsResultado.Tables[0].Rows[i]["codigocliente"].ToString());
            }
        }

        private void llenarCbxNitProducto()
        {          
            DataSet dsResultado = new DataSet();
            dsResultado = com.ConsultarNitProducto();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxNitProducto.Items.Add(dsResultado.Tables[0].Rows[i]["nitproducto"].ToString());
            }
        }

        private void llenarCbxCodigoDescuento()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = com.ConsultarCodigoDescueto();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxCodigoDescuento.Items.Add(dsResultado.Tables[0].Rows[i]["codigodescuento"].ToString());
            }
        }

        private void llenarCbxIdEmpleado()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = com.ConsultarIdEmpleado();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxIdEmpleado.Items.Add(dsResultado.Tables[0].Rows[i]["idempleado"].ToString());
            }
        }

        #endregion


    }
}
