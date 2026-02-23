using System.ComponentModel.DataAnnotations;

namespace HermanPortfolio.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string Institution { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public string? ExpectedGraduation { get; set; }
        public string? Achievements { get; set; }
    }
}