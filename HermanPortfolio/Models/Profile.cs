using System.ComponentModel.DataAnnotations;

namespace HermanPortfolio.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string ProfessionalTitle { get; set; }

        [Required]
        public string AboutMe { get; set; }

        public string? ProfilePhotoPath { get; set; }
        public string? Email { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? ResumeFilePath { get; set; }
    }
}