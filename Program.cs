using JobPortalWebsite.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICompanyService, CompanyService>();

// Add services to the container
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // your React app origin (no trailing slash)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
// Enable middleware
if (app.Environment.IsDevelopment())
{
    try
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Swagger setup failed: " + ex.Message);
    }

}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); // <== Moved after app is built

app.UseAuthorization();

app.MapControllers();

app.Run();
