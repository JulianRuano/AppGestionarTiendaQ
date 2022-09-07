using System.Data;
using System;
using appGestionarTienda.accesoDatos;
using System.Windows.Forms;

namespace appGestionarTienda.logica
{
    internal class DepositoBasura
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarDatosDepBasura(int codigoDeposito, string tipo, int nitProducto)
        {
            string consulta;
            consulta = "INSERT INTO DEPOSITOBASURA(CODIGODEPOSITO, TIPOBASURA, NITPRODUCTO) values("+codigoDeposito+ ", '"+ tipo + "'," +nitProducto+") ";            
            return dt.ejecutarDML(consulta);
        }
        #endregion

        #region Producto
        public DataSet ConsultarNitProducto()
        {
            string consulta;
            consulta = "SELECT nitproducto FROM producto";
            return dt.ejecutarSELECT(consulta);
        }
        #endregion

        #region Lote
        public DataSet ConsultarIdLote()
        {
            string consulta;
            consulta = "SELECT idlote FROM Lote";
            return dt.ejecutarSELECT(consulta);
        }
        #endregion

    }
}
