using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Empleado
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarEmpleados(int codigo, string nombre, string primerApellido, string segundoApellido, double telefono, string correo, double sueldo, String tipoEmpleado)
        {
            string consulta;
            consulta = "INSERT INTO EMPLEADO(IDEMPLEADO,NOMBREEMPLEADO,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOEMPLEADO,CORREOEMPLEADO,SUELDOEMPLEADO,TIPOEMPLEADO)" +
                "VALUES(" + codigo + ",'" + nombre + "','" + primerApellido + "','" + segundoApellido + "'," + telefono + ",'" + correo + "'," + sueldo + ",'" + tipoEmpleado + "')";
            return dt.ejecutarDML(consulta);
        }
        #endregion


    }
}
