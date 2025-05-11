namespace JobPortalWebsite.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Experience { get; set; }
        public string CompanyName { get; set; }
        public DateTime AppliedAt { get; set; }
    }
}
