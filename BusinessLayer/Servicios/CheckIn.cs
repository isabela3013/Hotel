using BusinessLayer.Modelos;
using DataAccessLayer.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Servicios
{
    public class CheckIn
    {
        private readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public List<Modelos.CheckIn> GetCheckIn()
        {
            var result = conexion.ExecuteQuery<Modelos.CheckIn>("SELECT * FROM TblCheckIn");

            return result.ToList();
        }

        public void PostCheckIn(Modelos.CheckIn checkIn)
        {
            try
            {
                conexion.ExecuteNonQuery("INSERT INTO tblcheckin (Id, ReservaId, FechaEntrada) VALUES (@Id, @ReservaId, @FechaEntrada)", new { Id = checkIn.Id, ReservaId = checkIn.ReservaId, FechaEntrada = checkIn.FechaEntrada });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
