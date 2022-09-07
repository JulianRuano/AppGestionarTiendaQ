using System;
using System.Windows.Forms;
using appGestionarTienda.logica;
using System.Data;


namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class RegistrarLote : Form
    {
        public RegistrarLote()
        {
            InitializeComponent();
            llenarCbxTProducto();
            llenarCbxProveedor();
            cbxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNitProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Lote objLote = new Lote();

        #region btn
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidadLote.Text == "" || txtIdLote.Text == "" || txtPrecioLote.Text == "" || cbxTipoProducto.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Capturo en variables lo que el usuario escribio de la interfaz 
                int precio, cantidad, idTipoProducto,NitProveedor, resultado;
                string idLote;
                idLote = txtIdLote.Text;
                precio = int.Parse(txtPrecioLote.Text);
                cantidad = int.Parse(txtCantidadLote.Text);
                NitProveedor =  int.Parse(cbxNitProveedor.Text);
                idTipoProducto = int.Parse(cbxTipoProducto.Text);
                //Envio las variables a la capa de la logica
                resultado = objLote.registrarLote(idLote, precio, cantidad, idTipoProducto, NitProveedor);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCantidadLote.Text = "";
                txtIdLote.Text = "";
                txtPrecioLote.Text = "";

            }
        }
        #endregion

        #region llenarCbx
        private void llenarCbxTProducto()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objLote.consultarIdTipoLote();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxTipoProducto.Items.Add(dsResultado.Tables[0].Rows[i]["IDTIPOPRODUCTO"].ToString());
            }
        }

        private void llenarCbxProveedor()
        {            
            DataSet dsResultado = new DataSet();
            dsResultado = objLote.consultarNitProveedor();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxNitProveedor.Items.Add(dsResultado.Tables[0].Rows[i]["nitproveedor"].ToString());
            }
        }
        #endregion

        #region keyPress
        private void txtPrecioLote_KeyPress(object sender, KeyPressEventArgs e)
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
