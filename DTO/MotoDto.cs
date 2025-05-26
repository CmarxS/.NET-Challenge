// DTOs/MotoDto.cs
using System.ComponentModel.DataAnnotations;

namespace ChallengeMottu.DTO
{
    public class MotoCreateDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "O modelo deve ter no máximo 50 caracteres.")]
        public string Modelo { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "O ano de fabricação deve estar entre 1900 e 2100.")]
        public int AnoFabricacao { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "A placa deve ter no máximo 20 caracteres.")]
        public string Placa { get; set; }

        [StringLength(50, ErrorMessage = "A categoria deve ter no máximo 50 caracteres.")]
        public string Categoria { get; set; }
    }
}
