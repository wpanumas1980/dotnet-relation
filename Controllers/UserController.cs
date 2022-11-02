using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace relationships.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
{
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> Get()
        {
            //  return Ok(await _context.Users.ToListAsync());
            var users = await _context.Users
                .ToListAsync();
            return users;
        }
    }
}