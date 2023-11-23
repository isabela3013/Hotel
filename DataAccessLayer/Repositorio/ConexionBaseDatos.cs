using Dapper;
using MySql.Data.MySqlClient;

namespace DataAccessLayer.Repositorio
{
    public class ConexionBaseDatos
    {
        private readonly string cadenaConexion;

        public ConexionBaseDatos(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public IEnumerable<T> ExecuteQuery<T>(string sql, object parameters = null)
        {
            try
            {
                using (var connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    return connection.Query<T>(sql, parameters);
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public int ExecuteNonQuery(string sql, object parameters = null)
        {
            try
            {
                using (var connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    return connection.Execute(sql, parameters);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
