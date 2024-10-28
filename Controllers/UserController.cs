using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Data;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if(!ModelState.IsValid) { return BadRequest(ModelState); }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok("User Created");
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var Users = await _context.UsersDetails.ToListAsync();
                return Ok(Users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetUserById(int Id)
        {
            try
            {
                var Users = await _context.UsersDetails.FindAsync(Id);
                return Ok(Users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateUser(int id,User user)
        {
            var currentUser = await _context.UsersDetails.FindAsync(id);
            if(currentUser == null)
            {
                return NotFound("User Not Existed in Database");
            }
            currentUser.UserId = id;
            currentUser.FirstName= user.FirstName;
            currentUser.LastName= user.LastName;
            currentUser.Email= user.Email;
            currentUser.DateOfBirth= user.DateOfBirth;
            await _context.SaveChangesAsync();
            return Ok("User Updated");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var currentUser = await _context.UsersDetails.FindAsync(id);
            if (currentUser == null)
            {
                return NotFound("User Not Existed in Database");
            }
           _context.UsersDetails.Remove(currentUser);
            await _context.SaveChangesAsync();
            return Ok("Deleted Succesfully");
        }



    }
}
