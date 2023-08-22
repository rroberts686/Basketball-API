using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIofMyChoice.Models
{
    [Table("Teams")]
    public class TeamModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TeamName { get; set; } = null!;
        [Required]
        public int TeamOvr { get; set; }

        public virtual ICollection<TeamModel> Players { get; set; } = null!; 




    }
}
