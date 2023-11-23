using DataAccessLayer.Repositorio;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace BusinessLayer.Servicios
{
    public class Habitacion
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public static List<Modelos.Habitacion> GetHabitaciones()
        {
            var result = conexion.ExecuteQuery<Modelos.Habitacion>("SELECT * FROM TblHabitaciones");

            foreach (var h in result)
            {
                h.TipoHabitacion = GetTipoHabitacionById(h.TipoHabitacionId);
            }

            return result.ToList();
        }

        public static Modelos.TipoHabitacion GetTipoHabitacionById(int id)
        {
            var result = conexion.ExecuteQuery<Modelos.TipoHabitacion>("SELECT * FROM TblTiposHabitaciones WHERE Id = @Id", new { Id = id });

            return result.First();
        }

        public static void PutHabitacionOcupada(int id, bool ocupada)
        {
            try
            {
                conexion.ExecuteQuery<Modelos.Habitacion>("UPDATE tblhabitaciones SET Ocupada = @Ocupada WHERE Id = @Id;", new
                {
                    Id = id,
                    Ocupada = ocupada
                });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
