using System;
using System.Data;
using System.Windows.Forms;


namespace appGestionarTiendaQ.consultas
{
    public partial class ClienteSucursal : Form
    {
        Consulta objConsulta = new Consulta();
        public ClienteSucursal()
        {
            InitializeComponent();
            ClienteSucursalDgv();
            ProductoRestantesDgv();
            SucursalGanancias();
            MaxProducto();
            NumEmpleados();
            Total();
        }

        private void ClienteSucursalDgv()
        {

            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultaClienteSucursal();
            this.chartClienteSucursal.Series[0].Points.Clear();
            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {                                            
                this.chartClienteSucursal.Series[0].Points.AddXY(dsResultado.Tables[0].Rows[i]["SUCURSAL"].ToString(), double.Parse(dsResultado.Tables[0].Rows[i]["Clientes"].ToString()));               
            }           
        }
        private void ProductoRestantesDgv()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultarProductosRestantes();
            dgvProductosRes.DataSource = dsResultado;
            dgvProductosRes.DataMember = "ResultadoDatos";
        }

        private void SucursalGanancias()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultarGananciasSucursal();
            this.chartSucursalganancias.Series[0].Points.Clear();          
            for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
            {
                this.chartSucursalganancias.Series[0].Points.AddXY(dsResultado.Tables[0].Rows[i]["nombresucursal"].ToString(), double.Parse(dsResultado.Tables[0].Rows[i]["Total"].ToString()));
            }
        }

        private void MaxProducto()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultarMaxProducto();
            lbNombrePro.Text =  dsResultado.Tables[0].Rows[0]["NOMBREPRODUCTO"].ToString();
            lbCantidadPro.Text = dsResultado.Tables[0].Rows[0]["ventas"].ToString();
        }

        private void Total()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultaTotalVentas();
            lbGanancia.Text = String.Format("{0:C}", dsResultado.Tables[0].Rows[0]["Total"]);
            
        }
        private void NumEmpleados()
        {
            DataSet dsResultado = new DataSet();
            dsResultado = objConsulta.ConsultaNumEmpleados();
            lbNumEmpledos.Text =  dsResultado.Tables[0].Rows[0]["count(idempleado)"].ToString();
        }
    }
}
