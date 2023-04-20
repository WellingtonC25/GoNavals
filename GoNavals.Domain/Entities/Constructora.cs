namespace GoNavals.Domain
{
    public class Constructora
    {
        public int Id { get; set; }
        public string? RNC { get; set; }
        public string? Descripcion { get; set; }
        //Recuerda analizar el tema de ciudad a traves de la relacion con Pais
        //public int IdCiudad { get; set; }
        public int PaisId { get; set; }
        public string? Direccion { get; set; }
        public long Telefono1 { get; set; }
        public long Telefono2 { get; set; }
        public long Celular { get; set; }
        public string? Email { get; set; }
        public virtual Pais? Pais { get; set; }
    }
}
