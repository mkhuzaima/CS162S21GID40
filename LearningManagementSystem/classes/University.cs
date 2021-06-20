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

        }
    }
}
