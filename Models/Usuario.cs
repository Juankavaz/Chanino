using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class Usuario : IdentityUser
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    // Relación con los mensajes de chat
    public ICollection<Mensaje> Mensajes
    {
        get; set;
    }
}
