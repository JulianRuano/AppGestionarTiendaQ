using appGestionarTienda.accesoDatos;
using System.Data;

namespace appGestionarTienda.logica
{
    internal class Consulta
    {
        Datos dt = new Datos();

  
        public DataSet ConsultarProductosRestantes()
        {
            string consulta;
            consulta = "SELECT NOMBREPRODUCTO, t.idlote , cantidad - ventas \"Productos_Restantes\", nombreprovedor ,telefonoprovedor " +
                       " FROM(SELECT NOMBREPRODUCTO, producto.idlote, COUNT(compra.idlote) ventas " +
                       " FROM producto INNER JOIN COMPRA " +
                       " on producto.idlote = compra.idlote " +
                       " GROUP BY  NOMBREPRODUCTO, producto.idlote)t INNER JOIN lote " +
                       " on lote.idlote = t.idlote" +
                       " INNER JOIN proveedor" +
                       " on proveedor.nitproveedor = lote.nitproveedor";
                       
            return dt.ejecutarSELECT(consulta);
        }

        public DataSet ConsultaClienteSucursal()
        {
            string consulta;
            consulta = "SELECT nombresucursal, COUNT(DISTINCT(codigocliente))\"Num Clientes\"" +
                       " FROM sucursal INNER JOIN asiste" +
                       " on sucursal.codigosucursal = asiste.codigosucursal" +
                       " GROUP BY nombresucursal" +
                       " ORDER BY \"Num Clientes\" DESC";
            return dt.ejecutarSELECT(consulta);
        }

    }
}
