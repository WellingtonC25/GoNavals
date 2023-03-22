namespace GoNavals.Domain
{
    public class ComandanteComandancia
    {
        public int Id { get; set; }
        public int IdComandancia { get; set; }
        public int IdComandante { get; set; }
        public virtual Comandancia? Comandancia { get; set; }
        public virtual Comandante? Comandante { get; set; }
    }
}
