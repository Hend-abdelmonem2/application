using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace challenge_Diabetes.Model
{
    public class Community
    {
        [Key]
        public int Id { get; set; }

        public string chat { get; set; }
        public string sharing { get; set; }
        public string post { get; set; }
        public ApplicationUser user { get; set; }
        [ForeignKey(nameof(user))]
        public string User_Id { get; set; }
    }
}
