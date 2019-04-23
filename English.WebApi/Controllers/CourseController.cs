using AutoMapper;
using English.Model.Model;
using English.Service;
using English.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace English.WebApi.Controllers
{
    public class CourseController : Controller
    {
        private readonly IMapper _mapper;
        ILessonService _LessonService;
        ICourseService _CourseService;
        public CourseController(ILessonService lessonService, ICourseService courseService, IMapper mapper)
        {
            this._LessonService = lessonService;
            this._CourseService = courseService;
            _mapper = mapper;

        }
        // GET: Product
        public ActionResult Detail(int courseId)
        {
            ViewBag.courseModel = _CourseService.GetById(courseId);
            var listlessonModel = _LessonService.GetAllElement(courseId);
            return View(listlessonModel);
          
        }
        public ActionResult Courses ()
        {
            var listcourseModel = _CourseService.GetAll();
            
            var viewModel = _mapper.Map<IEnumerable <Course> ,IEnumerable <CourseViewModel>>(listcourseModel);
            return View(viewModel);

        }
    }
}