namespace WebApplication2.Models
{
    public class Supplier
    {
        public int Id { get; set; }             // Llave primaria
        public required string Nombre { get; set; }   // Nombre del proveedor
        public required string Contacto { get; set; } // Información de contacto
        public required string Email { get; set; }    // Correo electrónico del proveedor
    }
}