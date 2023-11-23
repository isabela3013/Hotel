using BusinessLayer.Modelos;
using DataAccessLayer.Repositorio;

namespace BusinessLayer.Servicios
{
    public class Reserva
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public static List<Modelos.Reserva> GetReservas()
        {
            var result = conexion.ExecuteQuery<Modelos.Reserva>("SELECT * FROM TblReservas");

            foreach (var item in result)
            {
                var detalle = GetReservaDetalle(item.Id);
                if(detalle.Any())
                    item.ReservaDetalles = detalle;
            }

            return result.ToList();
        }

        public static List<Modelos.Reserva> GetReservasPendientes()
        {
            var result = conexion.ExecuteQuery<Modelos.Reserva>("SELECT * FROM tblreservas WHERE Id NOT IN (SELECT ReservaId FROM tblcheckout);");

            foreach (var item in result)
            {
                var detalle = GetReservaDetalle(item.Id);
                if (detalle.Any())
                    item.ReservaDetalles = detalle;
            }

            return result.ToList();
        }

        public static List<Modelos.Reserva> GetReservaId(int clienteId)
        {
            var result = conexion.ExecuteQuery<Modelos.Reserva>("SELECT * FROM TblReservas WHERE ClienteId = @clienteId", new { clienteId });
            return result.ToList();
        }

        public static List<ReservaDetalle> GetReservaDetalle(int idReserva)
        {
            var result = conexion.ExecuteQuery<ReservaDetalle>("SELECT * FROM TblReservasDetalles WHERE ReservaId = @idReserva", new { idReserva });

            return result.ToList();
        }

        public static List<Modelos.Reserva> PostReservas(Modelos.Reserva reserva)
        {
            conexion.ExecuteNonQuery("INSERT INTO TblReservas (Id, ClienteId, Personas) VALUES (@Id, @ClienteId, @Personas)", new { Id = reserva.Id, ClienteId = reserva.ClienteId, Personas = reserva.Personas});
            var result = conexion.ExecuteQuery<Modelos.Reserva>("SELECT * FROM TblReservas");

            foreach (var item in result)
            {
                item.ReservaDetalles = GetReservaDetalle(item.Id);
            }

            return result.ToList();
        }

        public static void PostReservaDetalle(ReservaDetalle reservaDetalle)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO tblreservasdetalles (Id, ReservaId, HabitacionId, Cantidad, FechaEntrada, FechaSalida) VALUES (@Id, @ReservaId, @HabitacionId, @Cantidad, @FechaEntrada, @FechaSalida)", new { 
                    Id = reservaDetalle.Id, 
                    ReservaId = reservaDetalle.ReservaId, 
                    HabitacionId = reservaDetalle.HabitacionId, 
                    Cantidad = reservaDetalle.Cantidad, 
                    FechaEntrada = reservaDetalle.FechaEntrada, 
                    FechaSalida = reservaDetalle.FechaSalida 
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
