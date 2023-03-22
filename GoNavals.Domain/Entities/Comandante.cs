namespace GoNavals.Domain
{
    public class Comandante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public int IdRango { get; set; }
        public virtual Rango Rango { get; set; }
        public virtual List<ComandanteComandancia>? ComandanteComandancias { get; set; }
    }
}
