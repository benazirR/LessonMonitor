using LessonMonitor.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LessonMonitor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        public QuestionsController() { }

        [HttpPost]
        public IEnumerable<Question> Add(string question)
        {
            if (string.IsNullOrEmpty(question))
            {
                throw new ArgumentException($"'{nameof(question)}' cannot be null or empty.");
            }

            List<Question> questions = new List<Question>();
            return questions;
        }
    }
}
