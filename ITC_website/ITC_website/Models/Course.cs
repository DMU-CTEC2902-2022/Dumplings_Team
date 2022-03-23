using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual string CourseName { get; set; }
        public virtual string CurseDescription { get; set; }

    }
}