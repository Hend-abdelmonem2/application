using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class Sugar_ReadingDTO
    {
        [Required]
        public int sugar_reading { get; set; }
        [Required]
        public string measurement_date { get; set; }
       // public DateTime DateTime { get; set; } = DateTime.Now;
        //public string userId { get; set; }
    }
}
