using BusinessLayer.Modelos;
using DataAccessLayer.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Servicios
{
    public class CheckOut
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public static List<Modelos.CheckOut> GetCheckOut()
        {
            var result = conexion.ExecuteQuery<Modelos.CheckOut>("SELECT * FROM TblCheckOut");

            return result.ToList();
        }

        public static List<Modelos.CheckOut> GetCheckOutByReserva()
        {
            var result = conexion.ExecuteQuery<Modelos.CheckOut>("SELECT * FROM TblCheckOut WHERE RegistroId = @Registro");

            return result.ToList();
        }

        public static List<Modelos.CheckOut> GetCheckOutByGenero(int genero)
        {
            var result = conexion.ExecuteQuery<Modelos.CheckOut>("SELECT c.* FROM tblreservas r INNER JOIN tblpersonas p ON R.ClienteId = P.Identificacion INNER JOIN tblcheckout c ON C.ReservaId = R.Id WHERE P.GeneroId = @Genero", new { Genero = genero });

            return result.ToList();
        }

        public static void PostCheckOut(Modelos.CheckOut checkOut)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO tblcheckout (Id, FechaSalida, PrecioTotal, MedioPagoId, ReservaId, Descuento) VALUES (@Id, @FechaSalida, @PrecioTotal, @MedioPagoId, @ReservaId, @Descuento)", new { 
                    Id = checkOut.Id,
                    FechaSalida = checkOut.FechaSalida,
                    PrecioTotal = checkOut.PrecioTotal,
                    MedioPagoId = checkOut.MedioPagoId,
                    ReservaId = checkOut.ReservaId,
                    Descuento = checkOut.Descuento,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Modelos.MedioPago> GetMediosPago()
        {
            var result = conexion.ExecuteQuery<Modelos.MedioPago>("SELECT * FROM TblMediosPago");

            return result.ToList();
        }
    }
}
