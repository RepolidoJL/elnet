using System.ComponentModel.DataAnnotations;

namespace REPOLIDO_MachineProblem1.Models
{
    public class StudentHonor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(75, 99)]
        public int Grade { get; set; }

        public string Honor { get; set; }
    }
}
