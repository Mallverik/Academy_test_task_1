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
       public List<Teacher> TeachersList = new List<Teacher>();
       public List<Student> StudentsList = new List<Student>();
        int isChoose;
        int idToChoose;

        //CREATE
        public void CreateTeachers()
        {

            TeachersList.Add(new Teacher());
            int countOfSubjects;
            
            foreach (Teacher teachers in TeachersList)
            {

                if (teachers.FirstName == null)
                {
                    Console.Write("Name:");
                    teachers.FirstName = Console.ReadLine();
                    Console.Write("Last name:");
                    teachers.LastName = Console.ReadLine();
                    Console.Write("Birth Date:");
                    teachers.BirthDate = Console.ReadLine();
                    Console.WriteLine("Choose person gender: 1 - Male; 2 - Female;");
                    isChoose = Convert.ToInt32(Console.ReadLine());
                    switch (isChoose)
                    {
                        case 1:
                            teachers.PersonGender = Gender.Male;
                            break;
                        case 2:
                            teachers.PersonGender = Gender.Female;
                            break;
                    }

                    teachers.ID = TeachersList.IndexOf(teachers) + 1;
                    Console.Write("Work Experience:");
                    teachers.WorkExperience = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Count of Subjects:");
                    countOfSubjects = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Subjects:");
                    teachers.TeacherSubjects = new List<string>();
                    teachers.TeacherSubjects.Capacity = countOfSubjects;

                    for (int i = 0; i < countOfSubjects; i++)
                    {
                        teachers.TeacherSubjects.Add(Console.ReadLine());
                    }
                }
            }
            
        }
        public void CreateStudents()
        {
            StudentsList.Add(new Student());

            foreach (Student students in StudentsList)
            {
                if (students.FirstName == null)
                {
                    Console.Write("Name:");
                    students.FirstName = Console.ReadLine();
                    Console.Write("Last name:");
                    students.LastName = Console.ReadLine();
                    Console.Write("Birth Date:");
                    students.BirthDate = Console.ReadLine();
                    Console.WriteLine("Choose person gender: 1 - Male; 2 - Female;");
                    isChoose = Convert.ToInt32(Console.ReadLine());
                    switch (isChoose)
                    {
                        case 1:
                            students.PersonGender = Gender.Male;
                            break;
                        case 2:
                            students.PersonGender = Gender.Female;
                            break;
                    }
                    students.ID = StudentsList.IndexOf(students) + 1;
                    Console.Write("Gradebook number:");
                    students.GradebookNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Course:");
                    students.StudentСourse = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Average grade:");
                    students.AverageGrades = Convert.ToInt32(Console.ReadLine());
                }
            }
            
        }

        //OUTPUT CREATED 
        public void OutputCreatedTeachers()
        {
            foreach (Teacher teachers in TeachersList)
            {
                Console.WriteLine(
                 "\nName: " + teachers.FirstName + "\n" +
                 "Last name : " + teachers.LastName + "\n" +
                 "Birth date :" + teachers.BirthDate + "\n" +
                 "Gender : " + teachers.PersonGender + "\n" +
                 "Teacher ID : " + teachers.ID + "\n" +
                 "Work experience: " + teachers.WorkExperience + "\n" +
                 "Subjects list: ");
                foreach (var subjects in teachers.TeacherSubjects)
                {
                    Console.WriteLine(subjects);
                }
                Console.WriteLine("\n");

            }
        }
        public void OutputCreatedStudents()
        {
            foreach (Student students in StudentsList)
            {
                Console.WriteLine(
                "Name: " + students.FirstName + "\n" +
                "Last Name: " + students.LastName + "\n" +
                "Birth Date: " + students.BirthDate + "\n" +
                "Student ID: " + students.ID + "\n" +
                "Gradebook number: " + students.GradebookNumber + "\n" +
                "Course: " + students.StudentСourse + "\n" +
                "Average grades: " + students.AverageGrades + "\n");
            }
        }
        
        //EDIT
        public void EditTeachers()
        {
            Console.Write("Enter teacher ID you want to edit:");
            idToChoose = Convert.ToInt32(Console.ReadLine());
            int countOfSubjects;


            Console.Write("Name:");
            TeachersList[idToChoose-1].FirstName = Console.ReadLine();
            Console.Write("Last name:");
            TeachersList[idToChoose-1].LastName = Console.ReadLine();
            Console.Write("Birth Date:");
            TeachersList[idToChoose-1].BirthDate = Console.ReadLine();
            Console.WriteLine("Choose person gender: 1 - Male; 2 - Female; 3 - Another");
            isChoose = Convert.ToInt32(Console.ReadLine());
            switch (isChoose)
            {

                case 1:
                    TeachersList[idToChoose-1].PersonGender = Gender.Male;
                    break;
                case 2:
                    TeachersList[idToChoose-1].PersonGender = Gender.Female;
                    break;
            }
            Console.Write("Work Experience:");
            TeachersList[idToChoose-1].WorkExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of Subjects:");
            countOfSubjects = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subjects:");
            TeachersList[idToChoose-1].TeacherSubjects = new List<string>();
            TeachersList[idToChoose-1].TeacherSubjects.Capacity = countOfSubjects;
            for (int i = 0; i < countOfSubjects; i++)
            {
                TeachersList[idToChoose-1].TeacherSubjects.Add(Console.ReadLine());
            }
            

        }

        public void EditStudents()
        {
            Console.Write("Name:");
            StudentsList[idToChoose].FirstName = Console.ReadLine();
            Console.Write("Last name:");
            StudentsList[idToChoose].LastName = Console.ReadLine();
            Console.Write("Birth Date:");
            StudentsList[idToChoose].BirthDate = Console.ReadLine();
            Console.WriteLine("Choose person gender: 1 - Male; 2 - Female; 3 - Another");
            isChoose = Convert.ToInt32(Console.ReadLine());
            switch (isChoose)
            {
                case 1:
                    StudentsList[idToChoose].PersonGender = Gender.Male;
                    break;
                case 2:
                    StudentsList[idToChoose].PersonGender = Gender.Female;
                    break;
            }
            
            Console.Write("Gradebook number:");
            StudentsList[idToChoose].GradebookNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Course:");
            StudentsList[idToChoose].StudentСourse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Average grade:");
            StudentsList[idToChoose].AverageGrades = Convert.ToInt32(Console.ReadLine());
            
        }

        //DELETE_FUNC
        public void DeleteTeachers()
        {
            Console.Write("Enter teacher ID you want to delete:");
            idToChoose = Convert.ToInt32(Console.ReadLine());
            TeachersList.Remove(TeachersList[idToChoose-1]);
            foreach(Teacher teachers in TeachersList)
            {
                teachers.ID = TeachersList.IndexOf(teachers) + 1;
            }
            
            
        }

        public void DeleteStudents()
        {
            Console.Write("Enter student ID you want to delete:");
            idToChoose = Convert.ToInt32(Console.ReadLine());
            StudentsList.Remove(StudentsList[idToChoose-1]);
            foreach (Student students in StudentsList)
            {
                students.ID = StudentsList.IndexOf(students) + 1;
            }
            
        }

        //OUTPUT_SORT_STUDENTS
        public void SortStudents(List <Student> SortStudentsList)
        {
            var students = SortStudentsList.OrderBy(sorted => sorted.LastName);

            foreach (Student sorted in students)
            {
                Console.WriteLine(
               "Last Name: " + sorted.LastName + "\n" +
               "Name: " + sorted.FirstName + "\n" +
               "Birth Date: " + sorted.BirthDate + "\n" +
               "Gender : " + sorted.PersonGender + "\n" +
               "Student ID: " + sorted.ID + "\n" +
               "Gradebook number: " + sorted.GradebookNumber + "\n" +
               "Course: " + sorted.StudentСourse + "\n" +
               "Average grades: " + sorted.AverageGrades + "\n");
            }
        }

        //TEST TASK LISTS
        
            List<Teacher> TestTeachers = new List<Teacher>()
            {

                 new Teacher("Олег",    "Пiцун",    "21.04.1991",   Gender.Male,    1, 4,       new List<string>()  {"subject1", "subject2" } ),
                 new Teacher("Богдан",  "Маслияк",  "15.07.1960",   Gender.Male, 2, 14,         new List<string>()  {"subject3", "subject4" } ),
                 new Teacher("Юрiй",    "Батько",   "10.10.1980",   Gender.Male,    3, 10,      new List<string>()  {"subject5", "subject6" } ),
                 new Teacher("Iгор",    "Якименко", "11.12.1970",   Gender.Male,    4, 13,      new List<string>()  {"subject7", "subject8" } )
            };
        
        
           public List<Student> StandartStudents = new List<Student>
            {
                 new Student ("Валентин",    "Гарматюк",         "14.02.1998",     Gender.Male ,       1, 1,   4,     60),
                 new Student ("Олег",        "Момотюк",          "22.07.1998",     Gender.Male ,       2, 2,   4,     90),
                 new Student ("Вiталiй",     "Кухарук",          "25.08.1998",     Gender.Male ,       3, 3,   4,     60),
                 new Student ("Роман",       "Капустинський",    "20.06.1998",     Gender.Male ,       4, 4,   4,     85),
                 new Student ("Михайло",     "Хомолюк",          "10.10.1998",     Gender.Male ,       5, 5,   4,     75),
                 new Student ("Роман",       "Сидорчук",         "10.12.1998",     Gender.Male ,       6, 6,   4,     60),
                 new Student ("Зоряна",      "Щирба",            "13.05.1998",     Gender.Female ,     7, 7,   4,     89),
                 new Student ("Юрiй",        "Радовець",         "29.02.1997",     Gender.Female ,     8, 8,   4,    100),
                 new Student ("Роман",       "Снєжик",           "09.03.1998",     Gender.Male ,       9, 9,   4,     95),
                 new Student ("Олександр",   "Коваль",           "15.09.1998",     Gender.Male ,       10, 10,  4,     77),

            };
            
        //OUTPUT TEST OBJECTS
        public void OutputTestTeachers()
        {
            foreach (Teacher teachers in TestTeachers)
            {
                Console.WriteLine(
                "Name: " + teachers.FirstName + "\n" +
                "Last name : " + teachers.LastName + "\n" +
                "Birth date :" + teachers.BirthDate + "\n" +
                "Gender : " + teachers.PersonGender + "\n" +
                "Teacher ID : " + teachers.ID + "\n" +
                "Work experience: " + teachers.WorkExperience + "\n" +
                "Subjects list: ");
                foreach (var subjects in teachers.TeacherSubjects)
                {
                    Console.WriteLine(subjects);
                }
                Console.WriteLine("\n");
            }
        }
       
    }
}
 