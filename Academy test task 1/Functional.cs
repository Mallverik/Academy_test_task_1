using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    class Functional
    {
        //GLOBAL LISTS
        List<Teacher> teachers_L = new List<Teacher>();
        List<Student> students_L = new List<Student>();


        //TEST TASK LISTS
        List<Teacher> standart_teachers = new List<Teacher>()
            {

                 new Teacher("Олег",    "Пiцун",    "21.04.1991",   Gender.Male,    1, 4,   new List<string>()  {"subject1", "subject2" } ),
                 new Teacher("Богдан",  "Маслияк",  "15.07.1960",   Gender.Another, 3, 14,  new List<string>()  {"subject3", "subject4" } ),
                 new Teacher("Юрiй",    "Батько",   "10.10.1980",   Gender.Male,    2, 10,  new List<string>()  {"subject5", "subject6" } ),
                 new Teacher("Iгор",    "Якименко", "11.12.1970",   Gender.Male,    4, 13,   new List<string>() {"subject7", "subject8" } )
            };

        List<Student> standart_students = new List<Student>
        {
            new Student ("Валентин",    "Гарматюк",         "14.02.1998",     Gender.Male ,       1, 1,   4,     60),
            new Student ("Олег",        "Момотюк",          "22.07.1998",     Gender.Male ,       2, 2,   4,     90),
            new Student ("Вiталiй",     "Кухарук",          "25.08.1998",     Gender.Male ,       3, 3,   4,     60),
            new Student ("Роман",       "Капустинський",    "20.06.1998",     Gender.Male ,       4, 4,   4,     85),
            new Student ("Михайло",     "Хомолюк",          "10.10.1998",     Gender.Male ,       5, 5,   4,     75),
            new Student ("Роман",       "Сидорчук",         "10.12.1998",     Gender.Male ,       6, 6,   4,     60),
            new Student ("Зоряна",      "Щирба",            "13.05.1998",     Gender.Male ,       7, 7,   4,     89),
            new Student ("Юрiй",        "Радовець",         "29.02.1997",     Gender.Another ,    8, 8,   4,    100),
            new Student ("Роман",       "Снєжик",           "09.03.1998",     Gender.Male ,       9, 9,   4,     95),
            new Student ("Олександр",   "Коваль",           "15.09.1998",     Gender.Male ,      10, 10,  4,     77),

        };

        //OUTPUT
        public void Output_Teachers()
        {
            foreach (Teacher teachers in standart_teachers)
            {
                Console.WriteLine(
                "Name: " + teachers.name + "\n" +
                "Last name : " + teachers.last_name + "\n" +
                "Birth date :" + teachers.birth_date + "\n" +
                "Gender : " + teachers.personGender + "\n" +
                "Teacher ID : " + teachers.teacher_ID + "\n" +
                "Work experience: " + teachers.work_experience + "\n" +
                "Subjects list: ");
                foreach (var subjects in teachers.subjects)
                {
                    Console.WriteLine(subjects);
                }
                Console.WriteLine("\n");
            }
        }

        public void Output_Students()
        {
            foreach (Student students in standart_students)
            {
                Console.WriteLine(
                "Name: " + students.name + "\n" +
                "Last Name: " + students.last_name + "\n" +
                "Birth Date: " + students.birth_date + "\n" +
                "Student ID: " + students.student_ID + "\n" +
                "Gradebook number: " + students.gradebook_number + "\n" +
                "Course: " + students.course + "\n" +
                "Average grades: " + students.average_grades + "\n");

            }
        }

    }
}
