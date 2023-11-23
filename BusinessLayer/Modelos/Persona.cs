namespace BusinessLayer.Modelos
{
    public class Persona
    {
        public int Identificacion { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int GeneroId { get; set; }
        public DateTimeOffset FechaNacimiento { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }

        public Genero? GeneroPersona { get; set; }
    }

    public class Genero
    {
        public int Id { get; set; }
        public string? GeneroNombre { get; set; }
        public string? GeneroDescripcion { get; set; }
    }
}
