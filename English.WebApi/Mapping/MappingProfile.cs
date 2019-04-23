using AutoMapper;
using English.Model.Model;
using English.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English.WebApi.Mapping
{
    internal class MappingProfile : Profile
    {
        protected  void Configure()
        {
           
            CreateMap<Course, CourseViewModel>();
            CreateMap<Lesson, LessonViewModel>();
            CreateMap<Text, TextViewModel>();
        }
    }
}