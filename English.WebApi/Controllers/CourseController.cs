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
        public ActionResult Detail(string id)
        {
            int courseid = int.Parse(id);
            ViewBag.courseModel = _mapper.Map<Course, CourseViewModel>(_CourseService.GetById(courseid));
            var listlessonModel = _LessonService.GetAllElement(courseid);
            var listlessonViewModel = _mapper.Map<IEnumerable<Lesson>, IEnumerable<LessonViewModel>>(listlessonModel);
            return View(listlessonViewModel);
          
        }
        public ActionResult Courses ()
        {
            var listcourseModel = _CourseService.GetAll();
            
            var viewModel = _mapper.Map<IEnumerable <Course> ,IEnumerable <CourseViewModel>>(listcourseModel);
            return View(viewModel);

        }
    }
}