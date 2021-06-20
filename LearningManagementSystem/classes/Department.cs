using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class Department
    {
        public string Name { get; set; }
        public int DegreeYear { get; set; }
        public List<String> ProgramsOffered;
        public int NoOfTeachers;
        public int NoofStudents { get; set; }
        public List<string> Courses { get; set; }
        public HOD HeadOfDepartment;

        public Department(string name, HOD headOfDepartment)
        {
            Name = name;
            HeadOfDepartment = headOfDepartment;
        }
    }
}
