namespace GoNavals.Domain
{
    public class ComandanteComandancia
    {
        public int Id { get; set; }
        public int ComandanciaId { get; set; }
        public int ComandanteId { get; set; }
        public virtual Comandancia? Comandancia { get; set; }
        public virtual Comandante? Comandante { get; set; }
    }
}
