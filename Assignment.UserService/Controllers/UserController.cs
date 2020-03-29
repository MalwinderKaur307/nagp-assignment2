using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.UserService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.UserService.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return new User
            {
                Name = "John",
                Age = 23,
                Email = "john.doe@google.com"
            };
        }
    }
}