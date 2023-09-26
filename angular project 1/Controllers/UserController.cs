using angular_project_1.Data;
using angular_project_1.dto;
using angular_project_1.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular_project_1.Controllers
{
    public class UserController : ControllerBase
    {


        private readonly ILogger<UserController> _logger;

        public UserController(
            //IClientRequestParametersProvider User,
            ILogger<UserController> logger)
        {
            //User = ;
            _logger = logger;
        }

        [HttpGet]
            public IEnumerable<Userdto> Get()
            {
            return Enumerable.Range(1, 5).Select(index => new Userdto
            {
                xp = 50,
                guild = "stu"


            })
                .ToArray();
            }
        
    }
}
