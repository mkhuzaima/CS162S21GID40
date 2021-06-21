using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class University
    {
        public Administrator Admin { get; set; }
        public List<Manager> managers { get; set; }
        
        public List<Department> departments { get; set; }

        public List<OfferedCourse> offeredCourses { get; set; }
        public List<RegisteredCourse> registeredCourses{ get; set; }

        static private University _instance;
        public static University instance
        {
            get
            {
                if (_instance == null)
                    _instance = new University();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }
        private University()
        {
            departments = new List<Department>();
            offeredCourses = new List<OfferedCourse>();
            registeredCourses = new List<RegisteredCourse>();
            managers = new List<Manager>();
        }
    }
}
