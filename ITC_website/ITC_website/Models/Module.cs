using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class Module
    {
        public virtual int ModuleCode { get; set; }
        public virtual string ModuleTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContents { get; set; }
        
    }
}