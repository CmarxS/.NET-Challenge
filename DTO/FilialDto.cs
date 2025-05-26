using System.ComponentModel.DataAnnotations;

namespace ChallengeMottu.DTOs
{
    public class FilialCreateDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "O nome da filial deve ter no máximo 100 caracteres.")]
        public string NomeFilial { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Informe o código da cidade.")]
        public int CodCidade { get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "O tamanho do pátio deve ser maior que zero.")]
        public decimal TamanhoPatio { get; set; }
    }
}
