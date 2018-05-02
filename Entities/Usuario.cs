namespace Demo.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public ActivoEnum Bloqueado { get; set; }
    }
}
