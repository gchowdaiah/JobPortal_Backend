using JobPortalWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService) // Fixed casing here
        {
            _companyService = companyService; // Properly using the injected service
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetCompanies()
        {
            return Ok(_companyService.GetAllCompanies());
        }

        [HttpGet("{name}")]
        public ActionResult<Company> GetCompany(string name)
        {
            var company = _companyService.GetCompanyByName(name);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }

        // DELETE api/company/{name}
        //[HttpDelete("{name}")]
        //public IActionResult DeleteCompany(string name)
        //{
        //    var company = _companyService.GetCompanyByName(name);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    // Assuming _companyService has a method to delete a company
        //    var isDeleted = _companyService.DeleteCompany(name);
        //    if (isDeleted)
        //    {
        //        return NoContent(); // Successful deletion (204 No Content)
        //    }
        //    else
        //    {
        //        return BadRequest("Failed to delete the company");
        //    }
        //}
    }
}
