using System.Data;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Descuento
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarDescuento(int codigo, int porcentaje)
        {
            string consulta;
            consulta = "INSERT INTO DESCUENTO(CODIGODESCUENTO,PORCENTAJE)VALUES(" + codigo + "," + porcentaje + ")";
            return dt.ejecutarDML(consulta);
        }
        #endregion


    }
}
