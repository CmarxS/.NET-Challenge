using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeMottu.Entities
{
    [Table("net_Moto")]
    public class Moto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        public int AnoFabricacao { get; set; }

        [Required]
        public string Placa { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }
        // public int FilialId { get; set; }
        //[ForeignKey(nameof(FilialId))]
        //public Filial Filial { get; set; }
    }
}
