using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    class Student : Person
    {
        public int GradebookNumber { get; set; }
        public int StudentСourse { get; set; }
        public int AverageGrades { get; set; }
        
        public Student(String FirstName, String LastName, String BirthDate, bool PersonGender, int ID, int GradebookNumber , int StudentCourse, int AverageGrades)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.PersonGender = PersonGender;
            this.ID = ID;
            this.GradebookNumber = GradebookNumber;
            StudentСourse = StudentCourse;
            this.AverageGrades = AverageGrades;
        }
        public Student ()
        {

        }
    }
}
