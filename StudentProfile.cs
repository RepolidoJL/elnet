using System.ComponentModel.DataAnnotations;

namespace REPOLIDO_MachineProblem1.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        [Range(75, 99)]
        public int Grade { get; set; }
    }
}
