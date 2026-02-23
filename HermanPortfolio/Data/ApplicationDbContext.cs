using HermanPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace HermanPortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profiles");
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ProfessionalTitle).IsRequired().HasMaxLength(100);
                entity.Property(e => e.AboutMe).IsRequired().HasMaxLength(1000);
                entity.Property(e => e.ProfilePhotoPath).IsRequired(false);
                entity.Property(e => e.Email).IsRequired(false).HasMaxLength(100);
                entity.Property(e => e.LinkedInUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.GitHubUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.ResumeFilePath).IsRequired(false).HasMaxLength(200);
            });

           
            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Projects");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Technologies).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.GitHubUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.LiveDemoUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.ScreenshotPath).IsRequired(false).HasMaxLength(200); 
                entity.Property(e => e.CompletionDate).IsRequired(false);
                entity.Property(e => e.DisplayOrder).IsRequired();
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Educations");
                entity.Property(e => e.Degree).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Institution).IsRequired().HasMaxLength(100);
                entity.Property(e => e.StartDate).IsRequired();
                entity.Property(e => e.EndDate).IsRequired(false);
                entity.Property(e => e.ExpectedGraduation).IsRequired(false).HasMaxLength(50);
                entity.Property(e => e.Achievements).IsRequired(false).HasMaxLength(500);
            });

        
            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skills");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Category).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DisplayOrder).IsRequired();
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("ContactInfos");
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LinkedInUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.GitHubUrl).IsRequired(false).HasMaxLength(200);
                entity.Property(e => e.PhoneNumber).IsRequired(false).HasMaxLength(20);
            });
        }
    }
}