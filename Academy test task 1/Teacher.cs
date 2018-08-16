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
            name = f_name;
            last_name = l_name;
            birth_date = b_date;
            p_gender = personGender;
            teacher_ID = t_ID;
            work_experience = experience;
            subjects = teacher_subjects;
        }

     /*   public Teacher(String create_name, String create_l_name, String create_b_date, int create_t_ID, int create_experience)
        {
            name = create_name;
            last_name = create_l_name;
            birth_date = create_b_date;
            teacher_ID = create_t_ID;
            work_experience = create_experience;
        }*/
    }
}
