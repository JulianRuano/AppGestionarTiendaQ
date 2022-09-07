using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appGestionarTienda.accesoDatos;

namespace appGestionarTienda.logica
{
    internal class Cliente
    {
        Datos dt = new Datos();

        #region Insert
        public int registrarCliente(int codigo, string nombre, string primerApellido, string segundoApellido, double telefono, string correo, string direccion)
        {
            string consulta;
            consulta = "INSERT INTO CLIENTE(CODIGOCLIENTE,NOMBRECLIENTE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,TELEFONOCLIENTE,CORREOCLIENTE,DIRECCION)" +
                "VALUES(" + codigo + ",'" + nombre + "','" + primerApellido + "','" + segundoApellido + "'," + telefono + ",'" + correo + "','" + direccion + "')";
            return dt.ejecutarDML(consulta);
        }
        #endregion
        
        
    }
}
