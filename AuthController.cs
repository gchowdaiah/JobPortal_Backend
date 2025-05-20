using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    // Register a new user
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Register user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
        if (existingUser != null)
        {
            return BadRequest(new { message = "User already exists." });
        }

        var newUser = new User
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = HashPassword(user.Password),
            Gender = user.Gender,
            Address = user.Address,
            MobileNo = user.MobileNo,
            Role = user.Role // Include Role property
        };

        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();

        return Ok("User registered successfully.");
    }



    // Login a user
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login loginUser)
    {
        if (loginUser == null || string.IsNullOrEmpty(loginUser.Email) || string.IsNullOrEmpty(loginUser.Password))
        {
            return BadRequest("Email and password are required.");
        }

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginUser.Email);
        if (user == null || !VerifyPassword(loginUser.Password, user.Password))
        {
            return Unauthorized("Invalid credentials.");
        }

        return Ok(new { message = "Login successful" });
    }

    // Helper method to hash passwords using bcrypt
    private string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    // Helper method to verify password using bcrypt
    private bool VerifyPassword(string password, string storedHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, storedHash);
    }

    // Example method to get all users (admin only)
    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _context.Users.ToListAsync();
        return Ok(users);
    }






    [HttpGet("users/{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound("User not found.");
        }

        return Ok(user);
    }

}
