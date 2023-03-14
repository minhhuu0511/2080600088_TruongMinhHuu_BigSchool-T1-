using _2080600088_TruongMinhHuu_BigSchool_T1_.Models;
using _2080600088_TruongMinhHuu_BigSchool_T1_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2080600088_TruongMinhHuu_BigSchool_T1_.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.CateGories.ToList()
            };
            return View(viewModel);
        }
    }
}
