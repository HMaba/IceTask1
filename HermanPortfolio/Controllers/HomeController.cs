using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HermanPortfolio.Data;
using HermanPortfolio.Models;
using HermanPortfolio.ViewModels;
using System.Diagnostics;

namespace HermanPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new PortfolioViewModel
            {
                Profile = await _context.Profiles.FirstOrDefaultAsync(),
                Skills = await _context.Skills.OrderBy(s => s.Category).ThenBy(s => s.DisplayOrder).ToListAsync(),
                Projects = await _context.Projects.OrderBy(p => p.DisplayOrder).ToListAsync(),
                Educations = await _context.Educations.OrderByDescending(e => e.StartDate).ToListAsync(),
                ContactInfo = await _context.ContactInfos.FirstOrDefaultAsync()
            };

            return View(viewModel);
        }

        public IActionResult DownloadResume()
        {
            var profile = _context.Profiles.FirstOrDefault();
            if (profile != null && !string.IsNullOrEmpty(profile.ResumeFilePath))
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", profile.ResumeFilePath.TrimStart('/'));
                if (System.IO.File.Exists(filePath))
                {
                    var fileBytes = System.IO.File.ReadAllBytes(filePath);
                    var fileName = Path.GetFileName(filePath);
                    return File(fileBytes, "application/pdf", fileName);
                }
            }
            return NotFound();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}