using BusinessLayer.Modelos;
using DataAccessLayer.Repositorio;

namespace BusinessLayer.Servicios
{
    public class Registro
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public static List<Modelos.Registro> GetRegistros()
        {
            var result = conexion.ExecuteQuery<Modelos.Registro>("SELECT * FROM TblRegistros");

            foreach (var item in result)
            {
                var detalle = GetRegistroDetalle(item.Id);
                if (detalle.Any())
                    item.Detalle = detalle;
            }

            return result.ToList();
        }

        public static List<Modelos.Registro> GetRegistroId(int reservaId)
        {
            var result = conexion.ExecuteQuery<Modelos.Registro>("SELECT * FROM TblRegistros WHERE ReservaId = @ReservaId", new { ReservaId = reservaId });
            return result.ToList();
        }

        public static List<RegistroDetalle> GetRegistroDetalle(int registroId)
        {
            var result = conexion.ExecuteQuery<RegistroDetalle>("SELECT * FROM TblRegistrosDetalles WHERE RegistroId = @registroId", new { registroId });

            return result.ToList();
        }

        public static void PostRegistro(Modelos.Registro reserva)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO tblregistros (Id, ClienteId, RegistroFecha, PrecioTotal, ReservaId) VALUES (@Id, @ClienteId, @RegistroFecha, @PrecioTotal, @ReservaId)", new
                {
                    Id = reserva.Id,
                    ClienteId = reserva.ClienteId,
                    RegistroFecha = reserva.RegistroFecha,
                    PrecioTotal = reserva.PrecioTotal,
                    ReservaId = reserva.ReservaId,
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void PostRegistroDetalle(RegistroDetalle registroDetalle)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO tblregistrosdetalles (Id, RegistroId, ServicioId, Cantidad, PrecioTotal) VALUES (@Id, @RegistroId, @ServicioId, @Cantidad, @PrecioTotal)", new
                {
                    Id = registroDetalle.Id,
                    RegistroId = registroDetalle.RegistroId,
                    ServicioId = registroDetalle.ServicioId,
                    Cantidad = registroDetalle.Cantidad,
                    PrecioTotal = registroDetalle.PrecioTotal,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
