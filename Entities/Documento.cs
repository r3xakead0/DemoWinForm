namespace Demo.Entities
{
    public class Documento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ActivoEnum Activo { get; set; }
    }
}
