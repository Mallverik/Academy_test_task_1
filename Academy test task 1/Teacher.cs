using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    class Teacher : Person
    {
        public int teacher_ID;
        public int work_experience;
        public List <string> subjects;



        public Teacher(String f_name, String l_name, String b_date, Gender p_gender, int t_ID, int experience, List<string> teacher_subjects)
        {
            this.name = f_name;
            this.last_name = l_name;
            this.birth_date = b_date;
            p_gender = personGender;
            this.teacher_ID = t_ID;
            this.work_experience = experience;
            subjects = teacher_subjects;
        }

        public Teacher ()
        {

        }
  
    }
}
