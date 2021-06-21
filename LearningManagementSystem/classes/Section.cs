using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class Section
    {
        public char Name { get; set; }
        public List<Student> students { get; set; }

        public List<OfferedCourses> offeredCourses { get; set; }
        
        Section()
        {
            students = new List<Student>();
            offeredCourses = new List<OfferedCourses>();
        }
    }
}
