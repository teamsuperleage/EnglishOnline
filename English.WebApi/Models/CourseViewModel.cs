using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English.WebApi.Models
{
    public class CourseViewModel
    {
        public string ID { set; get; }
        public string Name { set; get; }

        public int? STT { set; get; }
        public string Search { set; get; }
        public string Image { set; get; }
        public string Notice { set; get; }
        public string Id_Text { set; get; }
        public virtual IEnumerable<LessonViewModel> Lessons { set; get; }
        public virtual IEnumerable<TextViewModel> Texts { set; get; }
    }
}