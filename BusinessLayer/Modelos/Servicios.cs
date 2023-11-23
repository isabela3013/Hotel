using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modelos
{
    public class Servicios
    {
        public int Id { get; set; }
        public string? ServicioNombre { get; set; }
        public string? ServicioDescripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
