using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeMottu.Entities
{
    [Table("net_Funcionario")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAcesso { get; set; }

        [Required]
        [StringLength(50)]
        public string FuncaoUsuario { get; set; }

        [Required]
        public int IdFilial { get; set; }

        [ForeignKey(nameof(IdFilial))]
        public Filial Filial { get; set; }
    }
}
