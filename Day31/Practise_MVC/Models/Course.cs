using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practise_MVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string TutorName { get; set; }

        public string Duration { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}