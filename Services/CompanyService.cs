using System.Collections.Generic;
using System.Linq;
using JobPortalWebsite.Controllers;
using JobPortalWebsite.Models;
using Microsoft.EntityFrameworkCore;

public class CompanyService : ICompanyService
{
    private readonly List<Company> _companies;
    private readonly AppDbContext _context;
    public CompanyService(AppDbContext context)
    {
        _context = context;
        _companies = new List<Company>
        {
            // MNCs
            new Company
            {
                Name = "TCS",
                Description = "TCS is a global IT services, consulting, and business solutions organization.",
                Location = "Mumbai, India",
                Website = "https://www.tcs.com",
                Roles = new List<string> { "Software Engineer", "QA Analyst", "Business Analyst", "Dotnet Developer","Frontend Developer","Java Developer","Power BI Developer","Python Developer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years", "4-6 years", "6-10 years" },
                Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Capgemini",
                Description = "Capgemini is a global leader in consulting, digital transformation, and technology services.",
                Location = "Paris, France",
                Website = "https://www.capgemini.com",
                Roles = new List<string> { "Cloud Engineer", "Data Analyst", "SAP Consultant","Software Engineer", "Backend Developer","Frontend Developer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years", "4-6 years", "6-10 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Tech Mahindra",
                Description = "Tech Mahindra offers innovative and customer-centric digital experiences.",
                Location = "Pune, India",
                Website = "https://www.techmahindra.com",
                Roles = new List<string> { "Java Developer", "Network Engineer", "AI Specialist" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Cognizant",
                Description = "Cognizant is a leading provider of IT services, including digital, technology, consulting, and operations.",
                Location = "New Jersey, USA",
                Website = "https://www.cognizant.com",
                Roles = new List<string> { "Full Stack Developer", "Data Scientist", "DevOps Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Mindtree",
                Description = "Mindtree delivers digital transformation and technology services.",
                Location = "Bangalore, India",
                Website = "https://www.mindtree.com",
                Roles = new List<string> { "Frontend Developer", "UX Designer", "Cloud Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "L&T",
                Description = "Larsen & Toubro is a major technology, engineering, construction, and manufacturing company.",
                Location = "Mumbai, India",
                Website = "https://www.larsentoubro.com",
                Roles = new List<string> { "Civil Engineer", "Project Manager", "Mechanical Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "HCL",
                Description = "HCL Technologies is a next-generation global technology company.",
                Location = "Noida, India",
                Website = "https://www.hcltech.com",
                Roles = new List<string> { "Software Tester", "System Analyst", "Security Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Accenture",
                Description = "Accenture is a global professional services company with leading capabilities in digital, cloud, and security.",
                Location = "Dublin, Ireland",
                Website = "https://www.accenture.com",
                Roles = new List<string> { "Consultant", "Cloud Architect", "AI Developer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Infosys",
                Description = "Infosys is a global leader in next-generation digital services and consulting.",
                Location = "Bangalore, India",
                Website = "https://www.infosys.com",
                Roles = new List<string> { "Frontend Developer", "Backend Developer", "Cloud Architect" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Wipro",
                Description = "Wipro is a leading global information technology, consulting, and business process services company.",
                Location = "Bangalore, India",
                Website = "https://www.wipro.com",
                Roles = new List<string> { "Software Engineer", "Data Engineer", "Support Analyst" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            // Startups
           new Company
{
    Name = "Zerodha",
    Description = "Zerodha is India’s largest stockbroker, pioneering discount broking and online trading.",
    Location = "Bangalore, India",
    Website = "https://zerodha.com",
    Roles = new List<string> { "Frontend Developer", "Product Designer", "Support Executive" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "CRED",
    Description = "CRED is a members-only credit card bill payment platform that rewards users for timely payments.",
    Location = "Bangalore, India",
    Website = "https://cred.club",
    Roles = new List<string> { "Backend Developer", "Data Analyst", "Marketing Associate" },
    Experience = new List<string> { "Fresher", "1-3 years", "3-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Razorpay",
    Description = "Razorpay is a full-stack financial solutions company offering payment gateways and neo-banking services.",
    Location = "Bangalore, India",
    Website = "https://razorpay.com",
    Roles = new List<string> { "DevOps Engineer", "Technical Support Engineer", "Sales Executive" },
    Experience = new List<string> { "Fresher", "0-1 years", "1-3 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Meesho",
    Description = "Meesho is a social commerce platform enabling small businesses and individuals to sell products online.",
    Location = "Bangalore, India",
    Website = "https://www.meesho.com",
    Roles = new List<string> { "UX Designer", "Software Engineer", "Customer Experience Executive" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Swiggy",
    Description = "Swiggy is a leading food delivery platform in India, also expanding into grocery delivery and logistics.",
    Location = "Bangalore, India",
    Website = "https://www.swiggy.com",
    Roles = new List<string> { "Operations Manager", "Mobile App Developer", "Support Associate" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Groww",
    Description = "Groww is a fast-growing investment platform in India that allows users to invest in mutual funds, stocks, and more.",
    Location = "Bangalore, India",
    Website = "https://groww.in",
    Roles = new List<string> { "Software Engineer", "Investment Analyst", "Customer Success Executive" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-3 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Upstox",
    Description = "Upstox is a fintech startup providing low-cost trading and investment solutions.",
    Location = "Mumbai, India",
    Website = "https://upstox.com",
    Roles = new List<string> { "React Developer", "QA Tester", "Data Scientist" },
    Experience = new List<string> { "Fresher", "0-1 years", "1-3 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Slice",
    Description = "Slice is a credit-focused fintech startup offering simple, smart, and transparent credit solutions for young Indians.",
    Location = "Bangalore, India",
    Website = "https://sliceit.com",
    Roles = new List<string> { "Android Developer", "Product Manager", "Credit Risk Analyst" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Instamojo",
    Description = "Instamojo is a digital payments and eCommerce platform for small businesses in India.",
    Location = "Bangalore, India",
    Website = "https://www.instamojo.com",
    Roles = new List<string> { "Full Stack Developer", "Support Lead", "Digital Marketer" },
    Experience = new List<string> { "Fresher", "1-3 years", "3-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "UrbanClap (now Urban Company)",
    Description = "Urban Company is a platform for home services like beauty, plumbing, appliance repair, and more.",
    Location = "Gurgaon, India",
    Website = "https://www.urbancompany.com",
    Roles = new List<string> { "Mobile App Developer", "Business Analyst", "Operations Associate" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Notion",
    Description = "Notion is an all-in-one productivity workspace for notes, tasks, databases, and collaboration.",
    Location = "San Francisco, USA",
    Website = "https://www.notion.so",
    Roles = new List<string> { "Frontend Developer", "Content Strategist", "Community Manager" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Figma",
    Description = "Figma is a collaborative design platform helping teams create, test, and ship better designs.",
    Location = "San Francisco, USA",
    Website = "https://www.figma.com",
    Roles = new List<string> { "Design Engineer", "UI/UX Designer", "Growth Marketer" },
    Experience = new List<string> { "Fresher", "2-3 years", "3-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},


            // Product Companies
            new Company
            {
                Name = "Google",
                Description = "Google is a global technology leader focused on improving the ways people connect with information.",
                Location = "Mountain View, USA",
                Website = "https://www.google.com",
                Roles = new List<string> { "Software Engineer", "AI Researcher", "Product Manager" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Microsoft",
                Description = "Microsoft develops, licenses, and supports a wide range of software products and services.",
                Location = "Redmond, USA",
                Website = "https://www.microsoft.com",
                Roles = new List<string> { "Cloud Engineer", "Software Architect", "Security Analyst" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Adobe",
                Description = "Adobe is a leader in creative software and digital experiences.",
                Location = "San Jose, USA",
                Website = "https://www.adobe.com",
                Roles = new List<string> { "UX Designer", "Frontend Engineer", "AI Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Oracle",
                Description = "Oracle offers integrated cloud applications and platform services.",
                Location = "Austin, USA",
                Website = "https://www.oracle.com",
                Roles = new List<string> { "Database Administrator", "Cloud Consultant", "Java Developer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Ford",
                Description = "Ford is a global automotive company that designs, manufactures, and services vehicles.",
                Location = "Michigan, USA",
                Website = "https://www.ford.com",
                Roles = new List<string> { "Mechanical Engineer", "Embedded Systems Developer", "Data Analyst" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            // Healthcare
            new Company
            {
                Name = "Apollo",
                Description = "Apollo Hospitals is a leading healthcare provider in Asia.",
                Location = "Chennai, India",
                Website = "https://www.apollohospitals.com",
                Roles = new List<string> { "Medical Officer", "Healthcare Analyst", "Lab Technician" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Fortis",
                Description = "Fortis Healthcare is a leading integrated healthcare delivery service provider.",
                Location = "Delhi, India",
                Website = "https://www.fortishealthcare.com",
                Roles = new List<string> { "Nurse", "Pharmacist", "Medical Coder" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "Sun Pharma",
                Description = "Sun Pharmaceutical is the fourth largest specialty generic pharmaceutical company in the world.",
                Location = "Mumbai, India",
                Website = "https://www.sunpharma.com",
                Roles = new List<string> { "Research Scientist", "QA/QC Analyst", "Production Manager" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            // Manufacturing
            new Company
            {
                Name = "Tata Steel",
                Description = "Tata Steel is among the top steel producing companies globally.",
                Location = "Jamshedpur, India",
                Website = "https://www.tatasteel.com",
                Roles = new List<string> { "Mechanical Engineer", "Safety Officer", "Production Supervisor" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            new Company
            {
                Name = "JSW",
                Description = "JSW Group is a part of the O.P. Jindal Group with interests in steel, energy, infrastructure, and cement.",
                Location = "Mumbai, India",
                Website = "https://www.jsw.in",
                Roles = new List<string> { "Electrical Engineer", "Operations Manager", "Civil Engineer" },
                Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
                 Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
            },
            // Banking & Finance
           new Company
{
    Name = "ICICI Bank",
    Description = "ICICI Bank is a leading private sector bank in India offering a wide range of financial services.",
    Location = "Mumbai, India",
    Website = "https://www.icicibank.com",
    Roles = new List<string> { "Banking Officer", "Loan Officer", "Branch Manager" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Axis Bank",
    Description = "Axis Bank is one of the largest private sector banks in India offering comprehensive banking services.",
    Location = "Mumbai, India",
    Website = "https://www.axisbank.com",
    Roles = new List<string> { "Relationship Manager", "Operations Executive", "Credit Analyst" },
    Experience = new List<string> { "Fresher", "1-3 years", "3-6 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "State Bank of India",
    Description = "SBI is India's largest public sector bank offering banking services nationwide.",
    Location = "Mumbai, India",
    Website = "https://www.onlinesbi.com",
    Roles = new List<string> { "Probationary Officer", "Clerk", "Loan Processing Officer" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Punjab National Bank",
    Description = "PNB is a major public sector bank in India known for its extensive branch network and customer base.",
    Location = "New Delhi, India",
    Website = "https://www.pnbindia.in",
    Roles = new List<string> { "Banking Assistant", "Compliance Officer", "Risk Analyst" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Kotak Mahindra Bank",
    Description = "Kotak Mahindra Bank is a private sector bank offering innovative banking products and services.",
    Location = "Mumbai, India",
    Website = "https://www.kotak.com",
    Roles = new List<string> { "Sales Officer", "Relationship Officer", "Wealth Manager" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Yes Bank",
    Description = "Yes Bank is a private sector bank offering a wide range of corporate and retail banking services.",
    Location = "Mumbai, India",
    Website = "https://www.yesbank.in",
    Roles = new List<string> { "Retail Banking Officer", "Risk Analyst", "Customer Service Executive" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-3 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Bank of Baroda",
    Description = "Bank of Baroda is a major public sector bank in India with a strong global presence.",
    Location = "Vadodara, India",
    Website = "https://www.bankofbaroda.in",
    Roles = new List<string> { "Clerk", "Branch Operations Manager", "Credit Officer" },
    Experience = new List<string> { "Fresher", "0-1 years", "1-3 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "IndusInd Bank",
    Description = "IndusInd Bank is a new-generation Indian bank providing a range of banking services.",
    Location = "Mumbai, India",
    Website = "https://www.indusind.com",
    Roles = new List<string> { "Sales Executive", "Branch Manager", "Audit Officer" },
    Experience = new List<string> { "Fresher", "1-2 years", "2-5 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "IDFC FIRST Bank",
    Description = "IDFC FIRST Bank is a fast-growing private bank focused on retail and MSME lending.",
    Location = "Mumbai, India",
    Website = "https://www.idfcfirstbank.com",
    Roles = new List<string> { "Customer Relationship Officer", "Data Analyst", "Financial Associate" },
    Experience = new List<string> { "Fresher", "0-1 years", "1-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
},
new Company
{
    Name = "Federal Bank",
    Description = "Federal Bank is a leading private sector bank headquartered in Kerala, known for its digital banking services.",
    Location = "Aluva, Kerala, India",
    Website = "https://www.federalbank.co.in",
    Roles = new List<string> { "Relationship Executive", "Branch Sales Officer", "Loan Consultant" },
    Experience = new List<string> { "Fresher", "0-2 years", "2-4 years" },
     Skills = new List<string>{"HTML", "CSS", "JavaScript","Java","TypeScript","C","C++","C#","React","Angular","VueJs","Dotnet","ASP.NET core","ASP.NET MVC","ASP.NET Web API","React Native","SQL Server", "SQL","PL/SQL","NodeJS","Mendix","BackBase","Azure", "Blazor", "Entity Framework", "Django", "Flask", "FastAPI", "Pandas", "NumPy", "TensorFlow","Python", "Spring Boot", "AWS", "Google Cloud", "Power Apps","Git","Github","Jenkins","Devops" }
}


        };
    }

    public List<Company> GetAllCompanies() => _companies;

    public Company GetCompanyByName(string name) => _companies.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    object? ICompanyService.GetAllCompanies()
    {
        return GetAllCompanies();
    }

    object ICompanyService.GetCompanyByName(string name)
    {
        return GetCompanyByName(name);
    }
    public Company GetCompanyById(int id)
    {
        return _context.Companies.Find(id);
    }

    public void AddCompany(Company company)
    {
        _context.Companies.Add(company);
        _context.SaveChanges();
    }
    public bool DeleteCompany(string name)
    {
        var company = _context.Companies.FirstOrDefault(c => c.Name == name);
        if (company == null)
        {
            return false; // Company not found
        }

        _context.Companies.Remove(company);
        _context.SaveChanges(); // Ensure the changes are saved to the database
        return true; // Deletion was successful
    }
}
