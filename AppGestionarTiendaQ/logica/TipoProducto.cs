using appGestionarTienda.accesoDatos;


namespace appGestionarTienda.logica
{
    internal class TipoProducto
    {
        Datos dt = new Datos();

        #region Insert
        public int RegistrarTipoProducto(int id, string nombre)
        {
            //Paso 1: construyo la sentiacias sql para ingresar
            string consulta;
            consulta = "INSERT INTO TIPOPRODUCTO (IDTIPOPRODUCTO,NOMBRETIPOPRODUCTO) " +
                "VALUES(" + id + ",'" + nombre + "')";
            //Paso 2: Enviar la consulta a la capa de accesoDatos para ejecutar
            return dt.ejecutarDML(consulta);
        }
        #endregion

    }
}
