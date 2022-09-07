using appGestionarTienda.accesoDatos;
using System;
using System.Data;

namespace appGestionarTiendaQ.consultas
{
    internal class Consulta
    {
        Datos dt = new Datos();

  
        public DataSet ConsultarProductosRestantes()
        {
            string consulta;
            consulta = "SELECT NOMBREPRODUCTO Producto, t.idlote , cantidad - ventas \"Productos_Restantes\", nombreprovedor Proveedor,telefonoprovedor Telefono" +
                       " FROM(SELECT NOMBREPRODUCTO, producto.idlote, COUNT(compra.nitproducto) ventas " +
                       " FROM producto INNER JOIN COMPRA " +
                       " on producto.nitproducto = compra.nitproducto " +
                       " GROUP BY  NOMBREPRODUCTO, producto.idlote)t INNER JOIN lote " +
                       " on lote.idlote = t.idlote" +
                       " INNER JOIN proveedor" +
                       " on proveedor.nitproveedor = lote.nitproveedor";
                       
            return dt.ejecutarSELECT(consulta);
        }

        public DataSet ConsultaClienteSucursal()
        {
            string consulta;
            consulta = "SELECT nombresucursal SUCURSAL, COUNT(DISTINCT(compra.codigocliente))Clientes" +
            " FROM compra INNER join producto"+
            " on producto.nitproducto = compra.nitproducto"+
            " INNER JOIN sucursal"+
            " on producto.codigosucursal = sucursal.codigosucursal"+
            " GROUP BY nombresucursal"+
            " ORDER BY Clientes DESC";
            return dt.ejecutarSELECT(consulta);
        }
    
        public DataSet ConsultarMaxProducto()
        {
            string consulta;
            consulta = "SELECT NOMBREPRODUCTO, count(compra.nitproducto) ventas" +
            " FROM producto INNER JOIN COMPRA" +
            " on producto.nitproducto = compra.nitproducto" +
            " GROUP BY  NOMBREPRODUCTO" +
            " ORDER By ventas desc";
            return dt.ejecutarSELECT(consulta);
        }

        public DataSet ConsultaTotalVentas()
        {
            string consulta;
            consulta = "SELECT SUM(precioproducto*(100-porcentaje)/100)Total"+
            " FROM compra INNER join producto"+
            " on producto.nitproducto = compra.nitproducto"+
            " inner join descuento"+
            " on descuento.codigodescuento = compra.codigodescuento";
            return dt.ejecutarSELECT(consulta);
        }

        public DataSet ConsultaNumEmpleados()
        {
            string consulta;
            consulta = "SELECT count(idempleado) FROM empleado ";
            return dt.ejecutarSELECT(consulta);
        }
        public DataSet ConsultarGananciasSucursal()
        {
            string consulta;
            consulta = "SELECT nombresucursal,SUM(precioproducto)Total "+
            " FROM compra INNER join producto"+
            " on producto.nitproducto = compra.nitproducto"+
            " INNER join sucursal"+
            " on producto.codigosucursal = sucursal.codigosucursal"+
            " GROUP BY nombresucursal" +
            " ORDER BY Total desc";
            return dt.ejecutarSELECT(consulta);
        }

    }
}
