using DataAccessLayer.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Servicios
{
    public class Servicio
    {
        private static readonly ConexionBaseDatos conexion = new ConexionBaseDatos(Global.Cadena());

        public static List<Modelos.Servicios> GetServicios()
        {
            var result = conexion.ExecuteQuery<Modelos.Servicios>("SELECT * FROM TblServicios");

            return result.ToList();
        }
    }
}
