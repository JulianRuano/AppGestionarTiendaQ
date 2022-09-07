using appGestionarTienda.accesoDatos;
using System.Data;
using System;

namespace appGestionarTienda.logica
{
    internal class Lote
    {
        Datos dt = new Datos();

        #region Insert
        public int registrarLote(string idLote, int precio, int cantidad, int idTipoProducto,int NitProveedor)
        {
            //Paso 1: construyo la sentiacias sql para ingresar
            string consulta;
            consulta = "INSERT INTO LOTE  (idlote,preciolote,cantidad,idtipoproducto,nitproveedor)" +
                "VALUES('" + idLote + "'," + precio + "," + cantidad + "," + idTipoProducto + ","+NitProveedor+")";
            //Paso 2: Enviar la consulta a la capa de accesoDatos para ejecutar
            return dt.ejecutarDML(consulta);
        }
        #endregion


        #region Tipo Producto
        public DataSet consultarIdTipoLote()
        {
            string consulta;
            consulta = "SELECT IDTIPOPRODUCTO FROM TIPOPRODUCTO";
            //Envio la consulta al metodo ejecutarSelect en la capa de datos
            return dt.ejecutarSELECT(consulta);
        }

        #endregion

        #region Proveedor
        public DataSet consultarNitProveedor()
        {
            string consulta;
            consulta = "SELECT nitproveedor FROM proveedor";
            //Envio la consulta al metodo ejecutarSelect en la capa de datos
            return dt.ejecutarSELECT(consulta);
        }

        #endregion

    }
}
