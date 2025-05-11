namespace JobPortalWebsite.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Experience { get; set; }
        public List<string> Skills { get; set; }
    }
}
