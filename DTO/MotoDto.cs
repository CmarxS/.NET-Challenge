using System.ComponentModel.DataAnnotations;

namespace ChallengeMottu.DTOs
{
    public class MotoCreateDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "O modelo deve ter no máximo 50 caracteres.")]
        public string Modelo { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "O ano deve estar entre 1900 e 2100.")]
        public int AnoFabricacao { get; set; }

        [StringLength(50, ErrorMessage = "A categoria deve ter no máximo 50 caracteres.")]
        public string Categoria { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "A placa deve ter 7 caracteres.")]
        [RegularExpression(@"^[A-Z]{3}-\d{4}$", ErrorMessage = "A placa deve seguir o formato AAA-0000.")]
        public string Placa { get; set; }

        // Se quiser exigir que filiais sejam informadas:
        //[Required]
        //public int FilialId { get; set; }
    }
}
