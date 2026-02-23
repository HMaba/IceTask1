using HermanPortfolio.Models;

namespace HermanPortfolio.ViewModels
{
    public class PortfolioViewModel
    {
        public Profile Profile { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<Education> Educations { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }

    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}