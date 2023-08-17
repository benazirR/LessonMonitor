using System;

namespace LessonMonitor.Api.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatDateTime { get; set; }
        public Topic Topic { get; set; }
        public User User { get; set; }
    }
}
