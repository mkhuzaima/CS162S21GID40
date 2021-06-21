using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    class Administrator : PersonAbstract
    {
        public static Administrator instance
        { 
            get
            {
                if (Administrator.instance == null)
                    Administrator.instance = new Administrator();
                return Administrator.instance;
            }
            private set
            {
                Administrator.instance = value;
            }
        }
        
        private Administrator()
        {

        }


    }
}
