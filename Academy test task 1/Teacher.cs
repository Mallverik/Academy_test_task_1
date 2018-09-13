using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    class Teacher : Person
    {
        public int WorkExperience { get; set; }
        public List<string> TeacherSubjects { get; set; }

        public Teacher(String FirstName, String LastName, String BirthDate, bool PersonGender, int ID, int WorkExperience, List<string> TeacherSubjects)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.PersonGender = PersonGender;
            this.ID = ID;
            this.WorkExperience = WorkExperience;
            this.TeacherSubjects = TeacherSubjects;
        }

        public Teacher () {

        }
  
    }
}
