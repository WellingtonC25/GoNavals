namespace GoNavals.Domain
{
    public class Pais
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public  virtual List<Ciudad>? Ciudades { get; set; }

    }
}
