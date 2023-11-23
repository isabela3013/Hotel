using DataAccessLayer.Repositorio;

namespace BusinessLayer.Servicios
{
    public class Persona
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        #region Persona
        public static List<Modelos.Persona> GetPersonas()
        {
            var result = conexion.ExecuteQuery<Modelos.Persona>("SELECT * FROM TblPersonas");

            foreach (var o in result)
            {
                o.GeneroPersona = GetGeneroById(o.GeneroId);
            }

            return result.ToList();
        }

        public static Modelos.Persona GetPersonaById(int identificacion)
        {
            var result = conexion.ExecuteQuery<Modelos.Persona>("SELECT * FROM TblPersonas WHERE Identificacion = @Identificacion", new { Identificacion = identificacion });

            foreach (var o in result)
            {
                o.GeneroPersona = GetGeneroById(o.GeneroId);
            }

            return result.First();
        }

        public static Modelos.Persona GetPersonaByPago(string pago)
        {
            string query = "";
            if(pago == "menor")
            {
                query = "SELECT P.* FROM tblreservas r INNER JOIN tblpersonas p ON R.ClienteId = P.Identificacion INNER JOIN tblcheckout c ON C.ReservaId = R.Id ORDER BY c.PrecioTotal ASC";
            }
            else if (pago == "mayor")
            {
                query = "SELECT P.* FROM tblreservas r INNER JOIN tblpersonas p ON R.ClienteId = P.Identificacion INNER JOIN tblcheckout c ON C.ReservaId = R.Id ORDER BY c.PrecioTotal DESC";
            }

            var result = conexion.ExecuteQuery<Modelos.Persona>(query);

            return result.First();
        }

        

        public static void PostPersonas(Modelos.Persona persona)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO TblPersonas (Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, GeneroId, FechaNacimiento, Correo, Telefono) VALUES (@Identificacion, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @GeneroId, @FechaNacimiento, @Correo, @Telefono)", new
                {
                    Identificacion = persona.Identificacion,
                    PrimerNombre = persona.PrimerNombre,
                    SegundoNombre = persona.SegundoNombre,
                    PrimerApellido = persona.PrimerApellido,
                    SegundoApellido = persona.SegundoApellido,
                    GeneroId = persona.GeneroId,
                    FechaNacimiento = persona.FechaNacimiento,
                    Correo = persona.Correo,
                    Telefono = persona.Telefono
                });

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Generos
        public static List<Modelos.Genero> GetGeneros()
        {
            var result = conexion.ExecuteQuery<Modelos.Genero>("SELECT * FROM TblGeneros");

            return result.ToList();
        }

        public static Modelos.Genero GetGeneroById(int id)
        {
            var result = conexion.ExecuteQuery<Modelos.Genero>("SELECT * FROM TblGeneros WHERE Id = @Id", new { Id = id });

            return result.First();
        }
        #endregion
    }
}
