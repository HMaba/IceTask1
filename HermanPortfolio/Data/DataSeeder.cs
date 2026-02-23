using HermanPortfolio.Models;

namespace HermanPortfolio.Data
{
    public static class DataSeeder
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            if (context.Profiles.Any())
            {
                return;
            }

            var profile = new Profile
            {
                FullName = "Herman",
                ProfessionalTitle = "Final Year Studentr",
                AboutMe = "I'm a final year Bachelor of Computer and Information Sciences student in a Application Development degree. Through my studies, I've built practical projects including a Wages Claim System where employees submit claims for senior manager verification. I also collaborated on a team project to develop a business plan with timelines and budgets. These academic projects have given me hands-on experience with software development and teamwork.",
                Email = "hmabalane09@gmail.com",
                LinkedInUrl = "http://linkedin.com/in/herman-mabalane-95b9a1368",
                GitHubUrl = "https://github.com/St10278399im",
                ProfilePhotoPath = null,  
                ResumeFilePath = null     
            };
            context.Profiles.Add(profile);

            var skills = new List<Skill>
            {
                new Skill { Name = "C#", Category = "Languages", DisplayOrder = 1 },
                new Skill { Name = "Java", Category = "Languages", DisplayOrder = 2 },
                new Skill { Name = "ASP.NET Core", Category = "Frameworks", DisplayOrder = 1 },
                new Skill { Name = "SQL", Category = "Databases", DisplayOrder = 1 },
                new Skill { Name = "MongoDB", Category = "Databases", DisplayOrder = 2 },
                new Skill { Name = "Azure", Category = "Cloud", DisplayOrder = 1 },
                new Skill { Name = "GitHub", Category = "Tools", DisplayOrder = 1 },
            };
            context.Skills.AddRange(skills);

            var projects = new List<Project>
            {
                
                new Project
                {
                    Name = "Claim Sytem",
                    Description = "Wages claim system where an employee can submit a claim and it can be verified by senior managers",
                    Technologies = "C#, Visual Studio 2022, Microsoft Sql Management Studio ",
                    GitHubUrl = "https://github.com/St10278399im/Prog6212P3_Claims.git",
                    LiveDemoUrl = "https://youtu.be/acDj-WKYcuk",
                    ScreenshotPath = null,
                    DisplayOrder = 1
                },
                
            };
            context.Projects.AddRange(projects);

            var educations = new List<Education>
            {
                new Education
                {
                    Degree = "Bachelor of Computer and Information Sciences in Application Development",
                    Institution = "IIE MSA",
                    StartDate = new DateTime(2024, 2, 20),
                    EndDate = new DateTime(2026, 12, 30),
                    ExpectedGraduation = null,
                    Achievements = ""
                },
                new Education
                {
                    Degree = "Business Practice and Principles Certificate",
                    Institution = "Varsity College",
                    StartDate = new DateTime(2023, 2, 20),
                    EndDate = new DateTime(2023, 12, 15),
                    ExpectedGraduation = null,
                    Achievements = "Certificate of Completion"
                }
            };
            context.Educations.AddRange(educations);

            var contactInfo = new ContactInfo
            {
                Email = "hmabalane09@gmail.com",
                LinkedInUrl = "http://linkedin.com/in/herman-mabalane-95b9a1368",
                GitHubUrl = "https://github.com/St10278399im",
                PhoneNumber = ""
            };
            context.ContactInfos.Add(contactInfo);

            context.SaveChanges();
        }
    }
}