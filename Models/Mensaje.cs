using Microsoft.AspNetCore.Identity;

public class Mensaje
{
    public int Id { get; set; }
    public string Contenido { get; set; }
    public DateTime FechaEnvio { get; set; }

    // Clave foránea para el IdentityUser que envió el mensaje
    public int IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
}
