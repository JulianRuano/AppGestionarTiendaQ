using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro
{
    public partial class RegistrarDepBasura : Form
    {
        public RegistrarDepBasura()
        {
            InitializeComponent();
            llenarCbxNitProducto();
            cbxNitProductoDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoBasura.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        DepositoBasura depBasura = new DepositoBasura();

        #region btn
        private void btnDepositoBasura_Click(object sender, EventArgs e)
        {
            
                if (txtCodigoDeposito.Text == "" || cbxNitProductoDeposito.Text == "" || cbxTipoBasura.Text == "")
                {
                    MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int codigo, nitProducto, resultado;
                    string tipoBasura;
                    codigo = int.Parse(txtCodigoDeposito.Text);
                    tipoBasura = cbxTipoBasura.Text;
                    nitProducto = int.Parse(cbxNitProductoDeposito.Text);
                    resultado = depBasura.ingresarDatosDepBasura(codigo, tipoBasura, nitProducto);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtCodigoDeposito.Text = "";
                }        
        }
       
        #endregion

        #region llenarCbx
        private void llenarCbxNitProducto()
        {
            
            DataSet dsResultado = new DataSet();
            dsResultado = depBasura.ConsultarNitProducto();
          

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxNitProductoDeposito.Items.Add(dsResultado.Tables[0].Rows[i]["nitproducto"].ToString());
            }
        }

        #endregion

        #region keyPrees
        private void txtCodigoDeposito_KeyPress(object sender, KeyPressEventArgs e)
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
