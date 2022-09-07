using System.Data;
using System;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Sucursal
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarSucursal(int codigo, string nombre, string direccion, double telefono, int codigoEmpleado)
        {
            string consulta;
            consulta = "INSERT INTO SUCURSAL(CODIGOSUCURSAL,NOMBRESUCURSAL,DIRECCIONSUCURSAL,TELEFONOSUCURSAL,IDEMPLEADO)" +
                "VALUES(" + codigo + ",'" + nombre + "','" + direccion + "'," + telefono + "," + codigoEmpleado + ")";
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

        #endregion
    }
}
