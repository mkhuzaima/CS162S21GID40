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
        public Manager Mngr { get; set; }
        
        public List<Department> departments;

        public University()
        {
            departments = new List<Department>();

        }
    }
}
