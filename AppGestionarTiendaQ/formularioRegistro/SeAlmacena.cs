using System;
using System.Windows.Forms;
using System.Data;
using appGestionarTienda.logica;

namespace appGestionarTiendaQ.formularioRegistro
{
    public partial class SeAlmacena : Form
    {
        public SeAlmacena()
        {
            InitializeComponent();
            llenarCbxNitProducto();
            llenarCbxBodega();
            cbxCodigoBodega.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNitProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        Se_Almacena almacenar = new Se_Almacena();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxCodigoBodega.Text == "" || cbxNitProducto.Text == "" || calendarFechaSeAlmacena.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, nitProducto, resultado;
                string  fecha;

                codigo = int.Parse(cbxCodigoBodega.Text);
                nitProducto = int.Parse(cbxNitProducto.Text);
                fecha = calendarFechaSeAlmacena.Text;
                resultado = almacenar.se_almacena(codigo, nitProducto, fecha);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #region llenarCbx
        private void llenarCbxNitProducto()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = almacenar.ConsultarNitProducto();

            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxNitProducto.Items.Add(dsResultado.Tables[0].Rows[i]["nitproducto"].ToString());
            }
        }

        private void llenarCbxBodega()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = almacenar.ConsultarCodigoBodega();
            
            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                cbxCodigoBodega.Items.Add(dsResultado.Tables[0].Rows[i]["codigobodega"].ToString());
            }
        }
        #endregion
    }
}
