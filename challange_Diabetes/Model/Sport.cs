using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace challenge_Diabetes.Model
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Sport_Name")]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
