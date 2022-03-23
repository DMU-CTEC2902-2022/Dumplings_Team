using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class Staff
    {
        public virtual int StaffId { get; set; }
        public virtual string StaffName { get; set; }
        public virtual string StaffEmail { get; set; }
        public virtual string StaffModule { get; set; }

    }
}