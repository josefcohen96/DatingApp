using API.Data;
using API.Enteties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[ApiController]
[Route("api/[controller]")] // /api/users


public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        Console.WriteLine("UsersController was created");
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        Console.WriteLine("GetUsers method was called");
        
        var users = await _context.Users.ToListAsync();
        Console.WriteLine($"Number of users retrieved: {users.Count}");

        foreach (var user in users)
        {
            Console.WriteLine($"User ID: {user.Id}, User Name: {user.UserName}");
        }

        return users;
    }


    [HttpGet("{id}")] // /api/users/2

    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        Console.WriteLine($"GetUser method was called with id: {id}");

        return await _context.Users.FindAsync(id);
    }
}
