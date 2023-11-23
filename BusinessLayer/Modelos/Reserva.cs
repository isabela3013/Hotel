namespace BusinessLayer.Modelos
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int Personas { get; set;}

        public Persona? Cliente { get; set;}
        public List<ReservaDetalle>? ReservaDetalles { get; set; }
    }

    public class ReservaDetalle
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int HabitacionId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
