using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage  = "CPF do usuário é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF invalido.")]
        public required string Login { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public required string Senha { get; set; }
        [Display(Name = "Relembrar")]
        public bool Relembrar { get; set; }
    }
}
