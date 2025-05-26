using System.ComponentModel.DataAnnotations;

namespace ChallengeMottu.DTO
{
    public class FuncionarioCreateDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAcesso { get; set; }

        [Required]
        [StringLength(50)]
        public string FuncaoUsuario { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Informe o código da filial.")]
        public int IdFilial { get; set; }
    }
}
