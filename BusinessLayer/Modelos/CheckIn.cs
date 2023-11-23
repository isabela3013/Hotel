namespace BusinessLayer.Modelos
{
    public class CheckIn
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public DateTime FechaEntrada { get; set; }

        public Reserva? Reserva { get; set; }
    }
}
