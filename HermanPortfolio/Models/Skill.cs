using System.ComponentModel.DataAnnotations;

namespace HermanPortfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        public int DisplayOrder { get; set; }
    }
}