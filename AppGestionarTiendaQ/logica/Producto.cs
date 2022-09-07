using System;
using System.Data;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Producto
    {
        Datos dt = new Datos();

        #region MyRegion
        public int ingresarProducto(int codigo, string idLote, string nombre, int peso, double precio, string estado, int NitProveedor, int codigoSucursal)
        {
            string consulta;
            consulta = "INSERT INTO PRODUCTO(NITPRODUCTO,IDLOTE,NOMBREPRODUCTO,PESOPRODUCTO,PRECIOPRODUCTO,ESTADOPRODUCTO,NITPROVEEDOR,CODIGOSUCURSAL)" +
                "VALUES(" + codigo + ",'" + idLote + "','" + nombre + "'," + peso + "," + precio + ",'" + estado + "'," + NitProveedor + "," + codigoSucursal + ")";
            return dt.ejecutarDML(consulta);
        }
        #endregion

        #region Lote
        public DataSet ConsultarIdLote()
        {
            string consulta;
            consulta = "SELECT idlote FROM Lote";
            return dt.ejecutarSELECT(consulta);
        }

        public int sizeIdLote()
        {
            string consulta;
            consulta = "SELECT COUNT(idlote) FROM Lote";
            return Convert.ToInt32(dt.ejecutarSELECT(consulta).Tables[0].Rows[0]["COUNT(idlote)"].ToString());
        }
        #endregion

        #region Sucursal
        public DataSet ConsultarCodigoSucursal()
        {
            string consulta;
            consulta = "SELECT codigosucursal FROM SUCURSAL";
            return dt.ejecutarSELECT(consulta);
        }

        public int sizeCodigoSucursal()
        {
            string consulta;
            consulta = "SELECT COUNT(codigosucursal) FROM SUCURSAL";
            return Convert.ToInt32(dt.ejecutarSELECT(consulta).Tables[0].Rows[0]["COUNT(codigosucursal)"].ToString());
        }
        #endregion

        #region Proveedor
        public DataSet ConsultarNitProveedor()
        {
            string consulta;
            consulta = "SELECT nitproveedor FROM proveedor";
            return dt.ejecutarSELECT(consulta);
        }

        public int sizeNitProveedor()
        {
            string consulta;
            consulta = "SELECT COUNT(nitproveedor) FROM proveedor";
            return Convert.ToInt32(dt.ejecutarSELECT(consulta).Tables[0].Rows[0]["COUNT(nitproveedor)"].ToString());
        }
        #endregion

    }
}
