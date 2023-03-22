namespace GoNavals.Domain
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int PaisId { get; set; }
        public virtual Pais? Pais { get; set; }
    }
}
