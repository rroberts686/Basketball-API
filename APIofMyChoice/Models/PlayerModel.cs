using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIofMyChoice.Models
{
    [Table("Players")]
    public class PlayerModel
    {
        [Key]
 
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(2)]
        public string Position { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string Archetype { get; set; } = null!;
        [Required]
        public int JerseyNumber { get; set; }

        [ForeignKey("TeamId")]
        public int TeamId { get; set; }

        public virtual TeamModel? Team { get; set; }
    }
}
