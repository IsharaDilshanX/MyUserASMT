using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
            var users = _context.Users.ToList();

            return users;
        }

        //api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
            // var users = _context.Users.Find(id);
            // return users;
            return _context.Users.Find(id);
        }
    }
}