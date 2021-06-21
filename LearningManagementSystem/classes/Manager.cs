using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class Manager : PersonAbstract
    {
        public DateTime joinigDate { get; set; }
        public Manager()
        {
            joinigDate = DateTime.Now;
            DateOfBirth = DateTime.Now;
        }
    }
}
