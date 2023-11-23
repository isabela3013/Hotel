using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modelos
{
    public class Registro
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime RegistroFecha { get; set; }
        public decimal PrecioTotal { get; set; }
        public int ReservaId { get; set; }

        public List<RegistroDetalle>? Detalle { get; set; }
    }

    public class RegistroDetalle
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }
        public int ServicioId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }

        public Servicios? Servicio { get; set; }
    }
}
