using System;
using System.Data;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Bodega
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarBodega(int codigo, string nombre, int idEmpleado)
        {
            string consulta;
            consulta = "INSERT INTO BODEGA(CODIGOBODEGA,NOMBREBODEGA,IDEMPLEADO)"
              + "VALUES(" + codigo + ",'" + nombre + "'," + idEmpleado + ")";
            return dt.ejecutarDML(consulta);
        }
        #endregion

        #region Empleado
        public DataSet ConsultarIdEmpleado()
        {
            string consulta;
            consulta = "SELECT idempleado FROM empleado";
            return dt.ejecutarSELECT(consulta);
        }

        public int sizeIdEmpleado()
        {
            string consulta;
            consulta = "SELECT COUNT(idempleado) FROM empleado";
            return Convert.ToInt32(dt.ejecutarSELECT(consulta).Tables[0].Rows[0]["COUNT(idempleado)"].ToString());
        }
        #endregion
    }
}
