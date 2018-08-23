using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    class Student : Person
    {
        public int student_ID;
        public int gradebook_number;
        public int course;
        public int average_grades;


        public Student(String f_name, String l_name, String b_date, Gender p_gender, int s_ID, int g_number , int s_course, int grades)
        {
            name = f_name;
            last_name = l_name;
            birth_date = b_date;
            p_gender = personGender;
            student_ID = s_ID;
            gradebook_number = g_number;
            course = s_course;
            average_grades = grades;
        }
        public Student ()
        {

        }
    }
}
