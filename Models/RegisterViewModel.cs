using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required(ErrorMessage = "El campo Email es obligatorio")]
    [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida")]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }
}
