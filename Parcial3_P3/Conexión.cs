using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace Parcial3_P3
{
    // Clase encargada de administrar la conexión a MySQL
    public class Conexion
    {
        // Cadena de conexión a la base de datos
        private string cadena =
            "Server=localhost;Database=parcial3;Uid=root;Pwd=chiripa07;";

        // Método que devuelve una conexión lista para abrir
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }

}