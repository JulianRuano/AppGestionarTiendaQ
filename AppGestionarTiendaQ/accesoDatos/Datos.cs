using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;


namespace appGestionarTienda.accesoDatos
{
    class Datos
    {
        string cadenaConexion = "Data Source=localhost:1521/xe;User Id=tienda;Password=oracle";


        public int ejecutarDML(string consulta)
        {
            try
            {
                int filaAfectadas = 0;
                //paso 1: crear la conexion
                OracleConnection miConexion = new OracleConnection(cadenaConexion);
                //paso 2: crea obj de tipo oraclecommand
                OracleCommand miComando = new OracleCommand(consulta, miConexion);
                //paso 3: abrir la conexion 
                miConexion.Open();
                /*paso 4: ejecutar el comando al ejecutar un objecto de tipo comando
                este devulve las filas que se afectaron en la operacion DML*/
                filaAfectadas = miComando.ExecuteNonQuery();
                //cierro la conexion
                miConexion.Close();
                return filaAfectadas;
            }
            catch (Exception)
            { 
                return -1;
            }
            
        }

        public DataSet ejecutarSELECT(string consulta)
        {
            //paso 1: crear un dataset vacio
            DataSet ds = new DataSet();
            //paso 2: creo un adaptador 
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //paso 3: a traves de adaptador llenamos el dataset 
            miAdaptador.Fill(ds,"ResultadoDatos");
            //paso 4: retorno Dataset lleno
            return ds;
        }

    }
}
