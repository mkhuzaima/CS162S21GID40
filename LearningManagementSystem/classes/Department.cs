using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class Department
    {
        public List<Section> Sections { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Courses> Courses { get; set; }
        
        //public int NoOfTeachers { get; set; }
        
        public string Name { get; set; }
        public int DegreeYear { get; set; }
        public List<String> ProgramsOffered { get; set; }
     
        public HOD HeadOfDepartment { get; set; }

        public Department(string name, HOD headOfDepartment)
        {
            Name = name;
            HeadOfDepartment = headOfDepartment;

            Sections = new List<Section>();
            Teachers = new List<Teacher>();
            Courses = new List<Courses>();
            ProgramsOffered = new List<string>();
            
        }

        public int NumberOfStudents ()
        {
            int stdcount = 0;
            foreach (Section s in Sections)
            {
                stdcount += s.students.Count();
            }
            return stdcount;
        }
        public int NumberOfTeachers()
        {
            return Teachers.Count;
        }
    }
}
