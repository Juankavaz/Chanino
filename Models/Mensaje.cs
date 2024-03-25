public class Mensaje
{
    public int Id { get; set; }
    public string Contenido { get; set; }
    public DateTime FechaEnvio { get; set; }

    // Clave foránea para el usuario que envió el mensaje
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
