using System;
using System.Data;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Se_Almacena
    {
        Datos dt = new Datos();

        #region Insert
        public int se_almacena(int codigo, int nitProducto, string fecha)
        {
            string consulta;
            consulta = "INSERT INTO SE_ALMACENA(CODIGOBODEGA,NITPRODUCTO,FECHA)"
                    + "VALUES(" + codigo + "," + nitProducto + ",TO_DATE('" + fecha + "','DD-MM-YYYY'))";
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

        #region Bodega
        public DataSet ConsultarCodigoBodega()
        {
            string consulta;
            consulta = "SELECT codigobodega FROM bodega";
            return dt.ejecutarSELECT(consulta);
        }


        #endregion
    }
}
