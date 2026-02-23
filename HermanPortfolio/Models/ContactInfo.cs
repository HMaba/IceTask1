using System.ComponentModel.DataAnnotations;

namespace HermanPortfolio.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string? LinkedInUrl { get; set; }

        [Url]
        public string? GitHubUrl { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}