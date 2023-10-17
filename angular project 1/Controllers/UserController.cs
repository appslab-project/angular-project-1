using angular_project_1.Data;
using angular_project_1.dto;
using angular_project_1.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Security.Claims;

namespace angular_project_1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<ApplicationUser> Get()
        {
            var currentUser = GetCurrentUser();

            var info = new ApplicationUser
            {
                xp = currentUser.xp
            };

            return info;

        }

        private Models.ApplicationUser GetCurrentUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Models.ApplicationUser? user = _context.Users
                //.Include(user => user.guild)
                .SingleOrDefault(user => user.Id == userId);

            return user!;
        }
    }
}


