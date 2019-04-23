using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English.WebApi.Models
{
    public class LessonViewModel
    {
        public string ID { set; get; }
        public string Name { set; get; }

        public int? STT { set; get; }
        public string Search { set; get; }
        public string Notice { set; get; }
        public string Url_Image { set; get; }
        public string Url_Video { set; get; }
        public string Id_Text { set; get; }
        public string Id_Course { set; get; }
        public virtual CourseViewModel Courses { set; get; }

        public virtual IEnumerable<TextViewModel> Texts { set; get; }
    }
}