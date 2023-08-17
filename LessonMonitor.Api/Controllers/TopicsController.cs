using LessonMonitor.Api.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LessonMonitor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        public TopicsController() { }

        [HttpPost]
        public IEnumerable<Topic> Add(string theme) {
            if (string.IsNullOrEmpty(theme))
            {
                throw new ArgumentException($"'{nameof(theme)}' cannot be null");
            }

            List<Topic> topics = new List<Topic>();
            return topics;
        }   
    }
}
