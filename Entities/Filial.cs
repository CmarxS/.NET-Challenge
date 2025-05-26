using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeMottu.Entities
{
    [Table("net_Filial")]
    public class Filial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeFilial { get; set; }

        [Required]
        public int CodCidade { get; set; }

        [Required]
        public decimal TamanhoPatio { get; set; }
    }
}
