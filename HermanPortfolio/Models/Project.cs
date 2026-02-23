using System.ComponentModel.DataAnnotations;

namespace HermanPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string? Technologies { get; set; }
        public string? GitHubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
        public string? ScreenshotPath { get; set; }  // Made nullable
        public DateTime? CompletionDate { get; set; }
        public int DisplayOrder { get; set; }
    }
}