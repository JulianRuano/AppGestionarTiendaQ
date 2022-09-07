using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Proveedor
    {
        Datos dt = new Datos();

        #region Insert
        public int ingresarProveedor(int Codigo, string nombre, double telefono, string correo)
        {
            string consulta;
            consulta = "INSERT INTO PROVEEDOR(NITPROVEEDOR,NOMBREPROVEDOR,TELEFONOPROVEDOR,CORREOPROVEDOR)VALUES(" + Codigo + ",'" + nombre + "'," + telefono + ",'" + correo + "')";
            return dt.ejecutarDML(consulta);
        }
        #endregion

    }
}
