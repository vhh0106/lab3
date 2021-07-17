using lab3.Models;
using lab3.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.ViewModels
{
    public class CoursesViewModel
    {
        
    
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    
    }
}