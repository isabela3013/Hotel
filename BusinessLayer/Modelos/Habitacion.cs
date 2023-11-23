using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modelos
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int TipoHabitacionId { get; set; }
        public bool Ocupada { get; set; }

        public TipoHabitacion? TipoHabitacion { get; set; }
    }

    public class TipoHabitacion
    {
        public int Id { get; set; }
        public string? TipoNombre { get; set; }
        public string? TipoDescripcion { get; set; }
        public int Capacidad { get; set; }
        public decimal Precio { get; set; }
    }
}
