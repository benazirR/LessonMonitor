using Microsoft.AspNetCore.Mvc;
using System;
using LessonMonitor.Api.Models;
using System.Linq;
using LessonMonitor.DataAccess;
using LessonMonitor.BussinesLogic;
using LessonMonitor.Core.Services;

namespace LessonMonitor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _userService;

        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();

            return users == null ? NotFound() : Ok(users);
        }


        [HttpPost]
        public IActionResult Create(Models.User user)
        {
            var UserToCreate = new Core.User
            {
                Id = Guid.NewGuid(),
                Age = user.Age,
                Name = user.Name
            };

            _userService.Create(UserToCreate);

            return user == null ? NotFound() : Ok(user);
        }

    }
}
