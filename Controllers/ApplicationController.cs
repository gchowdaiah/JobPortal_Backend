using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using JobPortalWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApplicationController(AppDbContext context)
        {
            _context = context;
        }

        // Submit a new job application
        [HttpPost]
        public ActionResult<Application> SubmitApplication([FromBody] Application application)
        {
            if (application == null)
            {
                return BadRequest("Invalid application data.");
            }

            application.Id = 0; // Ensure no explicit identity value is set
            application.AppliedAt = DateTime.UtcNow;

            _context.Applications.Add(application);
            _context.SaveChanges();

            return CreatedAtAction(nameof(SubmitApplication), new { id = application.Id }, application);
        }

        // Update an existing job application
        [HttpPut("{id}")]
        public IActionResult UpdateApplication(int id, [FromBody] Application application)
        {
            var existingApplication = _context.Applications.FirstOrDefault(app => app.Id == id);
            if (existingApplication == null)
            {
                return NotFound();
            }

            existingApplication.Name = application.Name;
            existingApplication.Email = application.Email;
            existingApplication.Role = application.Role;
            existingApplication.CompanyName = application.CompanyName;
            existingApplication.AppliedAt = DateTime.UtcNow;

            _context.SaveChanges();

            return NoContent();
        }

        // Get all job applications
        [HttpGet]
        public ActionResult<IEnumerable<Application>> GetApplications()
        {
            return Ok(_context.Applications.ToList());
        }

        // Delete a job application
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            if (application == null)
                return NotFound();

            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
