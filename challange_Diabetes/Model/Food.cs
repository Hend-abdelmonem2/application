using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace challenge_Diabetes.Model
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [DisplayName("Food_Classfication")]
        [MaxLength(225)]
        public string classification { get; set; }
        [DisplayName("Meal_Type")]
        [MaxLength(225)]
        public string type { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
