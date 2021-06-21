using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{

    abstract class Teacher : PersonAbstract
    {
        public List<OfferedCourse> offeredCourses { get; set; }

        Teacher()
        {
            offeredCourses = new List<OfferedCourse>();
        }
    }
}
