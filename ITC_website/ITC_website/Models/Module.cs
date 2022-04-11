using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class Module
    {
        public virtual int ModuleId { get; set; }
        public virtual string ModuleCode { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleTitle { get; set; }
        
    }
}