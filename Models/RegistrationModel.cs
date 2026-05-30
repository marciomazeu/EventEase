using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome não pode exceder 50 caracteres.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Insira um endereço de e-mail válido.")]
        public string Email { get; set; } = string.Empty;
    }
}