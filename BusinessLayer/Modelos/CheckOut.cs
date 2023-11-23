using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modelos
{
    public class CheckOut
    {
        public int Id { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal PrecioTotal { get; set; }
        public int MedioPagoId { get; set; }
        public int ReservaId { get; set; }
        public decimal Descuento { get; set; }

        public CheckIn? CheckIn { get; set; }
        public MedioPago? MedioPago { get; set; }
        public Reserva? Reserva { get; set; }
    }

    public class MedioPago
    {
        public int Id { get; set; }
        public string? MedioPagoNombre { get; set;}
        public string? MedioPagoDescripcion { get; set;}
    }
}
