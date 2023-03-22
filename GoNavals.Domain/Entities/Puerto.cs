namespace GoNavals.Domain
{
    public class Puerto
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int IdPais { get; set; }
        public int IdCiudad { get; set; }
        public int IdZona { get; set; }
        public string? Direccion { get; set; }
        public long Telefono1 { get; set; }
        public long Telefono2 { get; set; }
        public long Celular { get; set; }
        public string? Email { get; set; }
        public virtual Ciudad? Ciudad { get; set; }
        public virtual Pais? Pais { get; set; }
        public virtual Zona? Zona { get; set; }
    }
}
