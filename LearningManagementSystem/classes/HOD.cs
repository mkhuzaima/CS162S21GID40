using System;

namespace LearningManagementSystem.classes
{
    public class HOD : Person
    {
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string ContactNubmer { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Qualificatio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public string GetAge()
        {
            return Lib.GetAge(DateOfBirth);
        }
    }
}