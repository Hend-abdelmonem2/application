using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class WeightDTO
    {
        [Required]
        public int weight { get; set; }
        [Required]
        public bool sport { get; set; }
    }
}
