using JobPortalWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostController : ControllerBase
    {
        private readonly AppDbContext _context;
        public JobPostController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateJobPost([FromBody] JobPost post)
        {
            post.PostedAt = DateTime.UtcNow;
            _context.JobPosts.Add(post);
            _context.SaveChanges();
            return Ok(post);
        }
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            return Ok(_context.JobPosts.ToList());
        }
        [HttpGet("{companyName}")]
        public IActionResult GetPostByCompany(string companyName)
        {
            return Ok(_context.JobPosts.Where(p => p.CompanyName == companyName).ToList());
        }
    }
}
