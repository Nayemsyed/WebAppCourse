using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> coursesdata = new List<Course>()
        {
            new Course(){CId=1,CName="Ravi",CFee=12000,Technology="Java",CStartDate=new DateTime(day:01,month:09,year:2023),CEndDate=new DateTime(day:01,month:10,year:2023) },
            new Course(){CId=2,CName="Raju",CFee=9000,Technology="C",CStartDate=new DateTime(day:01,month:06,year:2031),CEndDate=new DateTime(day:01,month:07,year:2023) },
            new Course(){CId=3,CName="Sita",CFee=8000,Technology="C#",CStartDate=new DateTime(day:01,month:10,year:2023),CEndDate=new DateTime(day:01,month:11,year:2023) },
            new Course(){CId=4,CName="Siri",CFee=6000,Technology="Python",CStartDate=new DateTime(day:01,month:09,year:2023),CEndDate=new DateTime(day:01,month:10,year:2023) },
            new Course(){CId=5,CName="Sama",CFee=7500,Technology="Testing",CStartDate=new DateTime(day:01,month:07,year:2023),CEndDate=new DateTime(day:01,month:08,year:2023) }
        };
        public ActionResult Index()
        {
            return View(coursesdata);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course cou)
        {
            if (ModelState.IsValid)
            {
                coursesdata.Add(cou);
                return RedirectToAction("Index");
            }
            return View(cou);
        }
    }
}