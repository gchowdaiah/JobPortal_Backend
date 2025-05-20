namespace JobPortalWebsite.Controllers
{
    public interface ICompanyService
    {
        //bool DeleteCompany(string name);
        object? GetAllCompanies();
        object GetCompanyByName(string name);
    }
}