namespace GoNavals.Domain
{
    public class Constructora
    {
        public int Id { get; set; }
        public string? RNC { get; set; }
        public string? Descripcion { get; set; }
        public int? PaisId { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Celular { get; set; }
        public string? Email { get; set; }
        public virtual Pais? Pais { get; set; }
    }
}
