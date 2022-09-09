using CursoWebApi6.Database;
using CursoWebApi6.Models.DatabaseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CursoWebApi6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UniversityDb? _db;
        public UsersController(UniversityDb db)
        {
            _db = db;
        }

       

        [HttpGet("[action]")]
        public async Task<ActionResult<List<User>>> GetUSers()
        {
            return Ok(await _db.Users.ToListAsync());
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> AddUSer(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return Ok(user.Id);
        }
    }
}