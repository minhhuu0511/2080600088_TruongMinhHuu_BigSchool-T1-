using _2080600088_TruongMinhHuu_BigSchool_T1_.Models;
using _2080600088_TruongMinhHuu_BigSchool_T1_.ViewModels;
using Microsoft.AspNet.Identity;
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

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.CateGories.ToList()
            };
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories=_dbContext.CateGories.ToList();    
                return View(viewModel);
            }    
            var couse = new Course()
            {
                LectureId = User.Identity.GetUserId(),
                DateTime=viewModel.GetDateTime(),
                CategoryId= viewModel.Category,
                Place=viewModel.Place,
            };
            _dbContext.Course.Add(couse);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}
