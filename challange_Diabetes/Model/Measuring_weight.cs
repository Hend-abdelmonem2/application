using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challenge_Diabetes.Model
{
    public class Measuring_weight
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int weight { get; set; }
        public bool sport { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;

        public ApplicationUser user { get; set; }
        [ForeignKey(nameof(user))]
        public string User_Id { get; set; }

    }
}
