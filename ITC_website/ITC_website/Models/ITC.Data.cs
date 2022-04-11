using ITC_website.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class ITCDataInitialiser : DropCreateDatabaseAlways<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {   
            //........COURSES DATABASE...................///////
            ITC_website.Models.Course cur1 = new ITC_website.Models.Course();
            cur1.CourseId = 1;
            cur1.CourseName = "ComputerScience";
            cur1.CurseDescription = "...";
            context.Courses.Add(cur1);

            ITC_website.Models.Course cur2 = new ITC_website.Models.Course();
            cur2.CourseId = 2;
            cur2.CourseName = "Software Engineering";
            cur2.CurseDescription = "...";
            context.Courses.Add(cur2);

            ITC_website.Models.Course cur3 = new ITC_website.Models.Course();
            cur3.CourseId = 3;
            cur3.CourseName = "Cyber Security";
            cur3.CurseDescription = "...";
            context.Courses.Add(cur3);



            //.........MODULES DATABASE.............../////////
            ITC_website.Models.Module mod1 = new ITC_website.Models.Module();
            mod1.ModuleId = 1;
            mod1.ModuleCode = "COS1903";
            mod1.ModuleTitle = "Scala Programming";
            mod1.ModuleDescription = "...";
            context.Modules.Add(mod1);

            ITC_website.Models.Module mod2 = new ITC_website.Models.Module();
            mod2.ModuleId = 2;
            mod2.ModuleCode = "COS1920";
            mod2.ModuleTitle = "Database Management";
            mod2.ModuleDescription = "...";
            context.Modules.Add(mod2);


            ITC_website.Models.Module mod3 = new ITC_website.Models.Module();
            mod3.ModuleId = 3;
            mod3.ModuleCode = "COS2905";
            mod3.ModuleTitle = "Object Oriented Programming (Java)";
            mod3.ModuleDescription = "...";
            context.Modules.Add(mod3);


            ITC_website.Models.Module mod4 = new ITC_website.Models.Module();
            mod4.ModuleId = 4;
            mod4.ModuleCode = "COS2910";
            mod4.ModuleTitle = "Database Management";
            mod4.ModuleDescription = "...";
            context.Modules.Add(mod4);

            ITC_website.Models.Module mod5 = new ITC_website.Models.Module();
            mod5.ModuleId = 5;
            mod5.ModuleCode = "COS3911";
            mod5.ModuleTitle = "Mobile Application";
            mod5.ModuleDescription = "...";
            context.Modules.Add(mod5);


            ITC_website.Models.Module mod6 = new ITC_website.Models.Module();
            mod6.ModuleId = 6;
            mod6.ModuleCode = "IMAT3611";
            mod6.ModuleTitle = "Computer Ethics and Privacy";
            mod6.ModuleDescription = "...";
            context.Modules.Add(mod6);


            ITC_website.Models.Module mod7 = new ITC_website.Models.Module();
            mod7.ModuleId = 7;
            mod7.ModuleCode = "COS3451";
            mod7.ModuleTitle = "Development Project";
            mod7.ModuleDescription = "...";
            context.Modules.Add(mod7);

            ITC_website.Models.Module mod8 = new ITC_website.Models.Module();
            mod8.ModuleId = 8;
            mod8.ModuleCode = "SE3906";
            mod8.ModuleTitle = "Interaction Design";
            mod8.ModuleDescription = "...";
            context.Modules.Add(mod8);


            ITC_website.Models.Module mod9 = new ITC_website.Models.Module();
            mod9.ModuleId = 9;
            mod9.ModuleCode = "SE3410";
            mod9.ModuleTitle = "Web Application Penetration Testing";
            mod9.ModuleDescription = "...";
            context.Modules.Add(mod9);


            ITC_website.Models.Module mod10 = new ITC_website.Models.Module();
            mod10.ModuleId = 10;
            mod10.ModuleCode = "SE3406";
            mod10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            mod10.ModuleDescription = "...";
            context.Modules.Add(mod10);


            ITC_website.Models.Module mod11 = new ITC_website.Models.Module();
            mod11.ModuleId = 11;
            mod11.ModuleCode = "SE3613";
            mod11.ModuleTitle = "Data Mining";
            mod11.ModuleDescription = "...";
            context.Modules.Add(mod11);


            ITC_website.Models.Module mod12 = new ITC_website.Models.Module();
            mod12.ModuleId = 12;
            mod12.ModuleCode = "SE3614";
            mod12.ModuleTitle = "Big Data & Business Models";
            mod12.ModuleDescription = "...";
            context.Modules.Add(mod12);


            ITC_website.Models.Module mod13 = new ITC_website.Models.Module();
            mod13.ModuleId = 13;
            mod13.ModuleCode = "SE3901";
            mod13.ModuleTitle = "C Programming";
            mod13.ModuleDescription = "...";
            context.Modules.Add(mod13);


            ITC_website.Models.Module mod14 = new ITC_website.Models.Module();
            mod14.ModuleId = 14;
            mod14.ModuleCode = "SE3902";
            mod14.ModuleTitle = "Computer Law and Cyber Security Management";
            mod14.ModuleDescription = "...";
            context.Modules.Add(mod14);


            ITC_website.Models.Module mod15 = new ITC_website.Models.Module();
            mod15.ModuleId = 15;
            mod15.ModuleCode = "SE3903";
            mod15.ModuleTitle = "Linux Security";
            mod15.ModuleDescription = "...";
            context.Modules.Add(mod15);


            ITC_website.Models.Module mod16 = new ITC_website.Models.Module();
            mod16.ModuleId = 16;
            mod16.ModuleCode = "SE3904";
            mod16.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            mod16.ModuleDescription = "...";
            context.Modules.Add(mod16);


            ITC_website.Models.Module mod17 = new ITC_website.Models.Module();
            mod17.ModuleId = 17;
            mod17.ModuleCode = "3905";
            mod17.ModuleTitle = "Malware Analysis";
            mod17.ModuleDescription = "...";
            context.Modules.Add(mod17);


            base.Seed(context);

        }
    }
}