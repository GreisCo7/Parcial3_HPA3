using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace Parcial3_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contraseña original que sera convertida a hash
            string password = "1234";

            // Generar hash utilizando BCrypt
            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            Console.WriteLine("Contraseña original: " + password);
            Console.WriteLine("Hash generado: " + hash);

            string usuario = "admin";

            // Crear instancia de la conexión a MySQL
            Conexion conexion = new Conexion();

            // Abrir conexión e insertar usuario y hash
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                    @"INSERT INTO usuarios(usuario,passwordHash)
                      VALUES(@usuario,@hash)";

                MySqlCommand cmd = new MySqlCommand(sql, cn);

                // Asignación de parámetros
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@hash", hash);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Usuario guardado correctamente.");
            }

            // Solicitar credenciales al usuario
            Console.Write("\nUsuario: ");
            string usuarioLogin = Console.ReadLine() ?? "";

            Console.Write("Contraseña: ");
            string passwordLogin = Console.ReadLine() ?? "";

            // Verificar credenciales contra la base de datos
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string sql =
                    "SELECT passwordHash FROM usuarios WHERE usuario = @usuario";

                MySqlCommand cmd = new MySqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@usuario", usuarioLogin);

                // Obtener el hash almacenado
                object resultado = cmd.ExecuteScalar();

                // Verificar si el usuario existe
                if (resultado != null)
                {
                    string hashGuardado = resultado.ToString() ?? "";

               
                    bool acceso =
                        BCrypt.Net.BCrypt.Verify(passwordLogin, hashGuardado);

                    if (acceso)
                    {

                        Console.WriteLine($"Bienvenido {usuarioLogin}");
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                }
                else
                {

                    Console.WriteLine("Usuario no existe");
                }
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
