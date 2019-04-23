using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace English.WebApi.Models
{
    public class TextViewModel
    {
       
        public string ID { set; get; }

        
        public string Question_A { set; get; }

       
        public string Question_B { set; get; }

        
        public string Question_C { set; get; }

      
        public string Question_D { set; get; }
        public int? STT { set; get; }
       
        public string Notice { set; get; }
      
        public string Result { set; get; }
       
        public string Id_Lesson { set; get; }

       
        public virtual LessonViewModel Lessons { set; get; }
        
        public string Id_Course { set; get; }
        public virtual CourseViewModel Courses { set; get; }

    }
}