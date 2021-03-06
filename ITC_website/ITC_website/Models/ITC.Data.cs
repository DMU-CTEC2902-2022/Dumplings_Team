using ITC_website.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITC_website.Models
{
    public class ITCDataInitialiser : DropCreateDatabaseAlways<ModuleContext>
    {
        protected override void Seed(ModuleContext context)
        {   
            //........COURSES DATABASE...................///////
            ITC_website.Models.Course cur1 = new ITC_website.Models.Course();
            cur1.CourseId = 1;
            cur1.CourseName = "ComputerScience";
            cur1.CourseDescription = "...";
            context.Courses.Add(cur1);

            ITC_website.Models.Course cur2 = new ITC_website.Models.Course();
            cur2.CourseId = 2;
            cur2.CourseName = "Software Engineering";
            cur2.CourseDescription = "...";
            context.Courses.Add(cur2);

            ITC_website.Models.Course cur3 = new ITC_website.Models.Course();
            cur3.CourseId = 3;
            cur3.CourseName = "Cyber Security";
            cur3.CourseDescription = "...";
            context.Courses.Add(cur3);



            //.........MODULES DATABASE.............../////////
            ITC_website.Models.Module mod1 = new ITC_website.Models.Module();
            mod1.ModuleId = 1;
            mod1.ModuleCode = "COS1903";
            mod1.ModuleTitle = "Scala Programming";
            mod1.ModuleDescription = "...";
            mod1.course = cur1;
            context.Modules.Add(mod1);

            ITC_website.Models.Module mod2 = new ITC_website.Models.Module();
            mod2.ModuleId = 2;
            mod2.ModuleCode = "COS1920";
            mod2.ModuleTitle = "Database Management";
            mod2.ModuleDescription = "...";
            mod2.course = cur1;
            context.Modules.Add(mod2);


            ITC_website.Models.Module mod3 = new ITC_website.Models.Module();
            mod3.ModuleId = 3;
            mod3.ModuleCode = "COS2905";
            mod3.ModuleTitle = "Object Oriented Programming (Java)";
            mod3.ModuleDescription = "...";
            mod3.course = cur1;
            context.Modules.Add(mod3);


            ITC_website.Models.Module mod4 = new ITC_website.Models.Module();
            mod4.ModuleId = 4;
            mod4.ModuleCode = "COS2910";
            mod4.ModuleTitle = "Database Management";
            mod4.ModuleDescription = "...";
            mod4.course = cur1;
            context.Modules.Add(mod4);

            ITC_website.Models.Module mod5 = new ITC_website.Models.Module();
            mod5.ModuleId = 5;
            mod5.ModuleCode = "COS3911";
            mod5.ModuleTitle = "Mobile Application";
            mod5.ModuleDescription = "...";
            mod5.course = cur1;
            context.Modules.Add(mod5);


            ITC_website.Models.Module mod6 = new ITC_website.Models.Module();
            mod6.ModuleId = 6;
            mod6.ModuleCode = "IMAT3611";
            mod6.ModuleTitle = "Computer Ethics and Privacy";
            mod6.ModuleDescription = "...";
            mod6.course = cur1;
            context.Modules.Add(mod6);


            ITC_website.Models.Module mod7 = new ITC_website.Models.Module();
            mod7.ModuleId = 7;
            mod7.ModuleCode = "COS3451";
            mod7.ModuleTitle = "Development Project";
            mod7.ModuleDescription = "...";
            mod7.course = cur1;
            context.Modules.Add(mod7);

            ITC_website.Models.Module mod8 = new ITC_website.Models.Module();
            mod8.ModuleId = 8;
            mod8.ModuleCode = "SE3906";
            mod8.ModuleTitle = "Interaction Design";
            mod8.ModuleDescription = "...";
            mod8.course = cur2;
            context.Modules.Add(mod8);


            ITC_website.Models.Module mod9 = new ITC_website.Models.Module();
            mod9.ModuleId = 9;
            mod9.ModuleCode = "SE3410";
            mod9.ModuleTitle = "Web Application Penetration Testing";
            mod9.ModuleDescription = "...";
            mod9.course = cur2;
            context.Modules.Add(mod9);


            ITC_website.Models.Module mod10 = new ITC_website.Models.Module();
            mod10.ModuleId = 10;
            mod10.ModuleCode = "SE3406";
            mod10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            mod10.ModuleDescription = "...";
            mod10.course = cur2;
            context.Modules.Add(mod10);


            ITC_website.Models.Module mod11 = new ITC_website.Models.Module();
            mod11.ModuleId = 11;
            mod11.ModuleCode = "SE3613";
            mod11.ModuleTitle = "Data Mining";
            mod11.ModuleDescription = "...";
            mod11.course = cur2;
            context.Modules.Add(mod11);


            ITC_website.Models.Module mod12 = new ITC_website.Models.Module();
            mod12.ModuleId = 12;
            mod12.ModuleCode = "SE3614";
            mod12.ModuleTitle = "Big Data & Business Models";
            mod12.ModuleDescription = "...";
            mod12.course = cur2;
            context.Modules.Add(mod12);


            ITC_website.Models.Module mod13 = new ITC_website.Models.Module();
            mod13.ModuleId = 13;
            mod13.ModuleCode = "SE3901";
            mod13.ModuleTitle = "C Programming";
            mod13.ModuleDescription = "...";
            mod13.course = cur3;
            context.Modules.Add(mod13);


            ITC_website.Models.Module mod14 = new ITC_website.Models.Module();
            mod14.ModuleId = 14;
            mod14.ModuleCode = "SE3902";
            mod14.ModuleTitle = "Computer Law and Cyber Security Management";
            mod14.ModuleDescription = "...";
            mod14.course = cur3;
            context.Modules.Add(mod14);


            ITC_website.Models.Module mod15 = new ITC_website.Models.Module();
            mod15.ModuleId = 15;
            mod15.ModuleCode = "SE3903";
            mod15.ModuleTitle = "Linux Security";
            mod15.ModuleDescription = "...";
            mod15.course = cur3;
            context.Modules.Add(mod15);


            ITC_website.Models.Module mod16 = new ITC_website.Models.Module();
            mod16.ModuleId = 16;
            mod16.ModuleCode = "SE3904";
            mod16.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            mod16.ModuleDescription = "...";
            mod16.course = cur3;
            context.Modules.Add(mod16);


            ITC_website.Models.Module mod17 = new ITC_website.Models.Module();
            mod17.ModuleId = 17;
            mod17.ModuleCode = "SE3905";
            mod17.ModuleTitle = "Malware Analysis";
            mod17.ModuleDescription = "...";
            mod17.course = cur3;
            context.Modules.Add(mod17);

            ITC_website.Models.Module mod18 = new ITC_website.Models.Module();
            mod18.ModuleId = 18;
            mod18.ModuleCode = "IMAT3611";
            mod18.ModuleTitle = "Computer Ethics and Privacy";
            mod18.ModuleDescription = "...";
            mod18.course = cur2;
            context.Modules.Add(mod18);

            ITC_website.Models.Module mod19 = new ITC_website.Models.Module();
            mod19.ModuleId = 19;
            mod19.ModuleCode = "IMAT3611";
            mod19.ModuleTitle = "Computer Ethics and Privacy";
            mod19.ModuleDescription = "...";
            mod19.course = cur3;
            context.Modules.Add(mod19);

            ITC_website.Models.Module mod20 = new ITC_website.Models.Module();
            mod20.ModuleId = 20;
            mod20.ModuleCode = "COS3451";
            mod20.ModuleTitle = "Development Project";
            mod20.ModuleDescription = "...";
            mod20.course = cur2;
            context.Modules.Add(mod20);

            ITC_website.Models.Module mod21 = new ITC_website.Models.Module();
            mod21.ModuleId = 21;
            mod21.ModuleCode = "COS3451";
            mod21.ModuleTitle = "Development Project";
            mod21.ModuleDescription = "...";
            mod21.course = cur3;
            context.Modules.Add(mod21);


            base.Seed(context);

        }
    }
}