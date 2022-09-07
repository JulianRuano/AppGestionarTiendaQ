using System;
using System.Data;
using System.Windows.Forms;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Compra
    {
        Datos dt = new Datos();
        #region Insert
        public int AgregarCompra(int codigo, int nitProducto, string fecha, string tipoPago,int codigoDescuento, int idEmpleado)
        {
            string consulta;
            consulta = "INSERT INTO COMPRA(CODIGOCLIENTE,NITPRODUCTO,FECHA,TIPOPAGO,CODIGODESCUENTO,IDEMPLEADO) VALUES (" + codigo + "," + nitProducto + ",TO_DATE('" + fecha + "','DD-MM-YYYY'),'" + tipoPago + "',"+ codigoDescuento +","+idEmpleado+")";
            return dt.ejecutarDML(consulta);
        }
        #endregion

        #region Cliente
        public DataSet ConsultarCodigoCliente()
        {
            string consulta;
            consulta = "SELECT codigocliente FROM CLIENTE";
            return dt.ejecutarSELECT(consulta);
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

        public DataSet ConsultarCodigoDescueto()
        {
            string consulta;
            consulta = "SELECT codigodescuento FROM descuento";
            return dt.ejecutarSELECT(consulta);
        }

        public DataSet ConsultarIdEmpleado()
        {
            string consulta;
            consulta = "SELECT idempleado FROM empleado";
            return dt.ejecutarSELECT(consulta);
        }
    }
}
