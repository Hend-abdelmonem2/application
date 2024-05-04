using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class blood_pressureDTO
    {
        [Required]
        public int Diastolic_pressure { get; set; }
        [Required]
        public int Systolic_pressure { get; set; }
        public int Heart_rate { get; set; }
    }
}
