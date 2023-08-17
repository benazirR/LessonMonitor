using System;

namespace LessonMonitor.Api.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(100, 1)]
        [Display]
        public int Age { get; set; }
    }

    public class RequiredAttribute : Attribute
    {

    }

    public class RangeAttribute : Attribute
    {
        public int MaxValue { get; }
        public int MinValue { get; }
        public string test;

        public RangeAttribute(int maxValue, int minValue)
        {
            MaxValue = maxValue;
            MinValue = minValue;
        }
    }

    public class DescriptionAttribute : Attribute
    {
        public string Text { get; }

        public DescriptionAttribute(string text)
        {
            Text = text;
        }
    }

    public class DisplayAttribute : Attribute
    {

    }
}
