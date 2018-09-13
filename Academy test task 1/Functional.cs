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
        
        int IDSelection;
        int GenderSelection;
        string SelectedGender;
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
                    GenderSelection = Convert.ToInt32(Console.ReadLine());
                    switch (GenderSelection)
                    {
                        case 1:
                            teachers.PersonGender = true;
                            break;
                        case 2:
                            teachers.PersonGender = false;
                            break;
                        default:
                            throw new Exception("Incorrect input data;");
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
                    GenderSelection = Convert.ToInt32(Console.ReadLine());
                    switch (GenderSelection)
                    {
                        case 1:
                            students.PersonGender = true;
                            break;
                        case 2:
                            students.PersonGender = false;
                            break;
                        default:
                            throw new Exception("Incorrect input data");
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
                if (teachers.PersonGender) {
                    SelectedGender = "Male";
                } else {
                    SelectedGender = "Female";
                }
                Console.WriteLine(
                 "\nName: " + teachers.FirstName + "\n" +
                 "Last name : " + teachers.LastName + "\n" +
                 "Birth date :" + teachers.BirthDate + "\n" +
                 "Gender : " + SelectedGender + "\n" +
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
                if (students.PersonGender) {
                    SelectedGender = "Male";
                } else {
                    SelectedGender = "Female";
                }
                Console.WriteLine(
                "Name: " + students.FirstName + "\n" +
                "Last Name: " + students.LastName + "\n" +
                "Birth Date: " + students.BirthDate + "\n" +
                "Gender: " + SelectedGender + "\n" +
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
            IDSelection = Convert.ToInt32(Console.ReadLine());
            int countOfSubjects;


            Console.Write("Name:");
            TeachersList[IDSelection-1].FirstName = Console.ReadLine();
            Console.Write("Last name:");
            TeachersList[IDSelection-1].LastName = Console.ReadLine();
            Console.Write("Birth Date:");
            TeachersList[IDSelection-1].BirthDate = Console.ReadLine();
            Console.WriteLine("Choose person gender: 1 - Male; 2 - Female; 3 - Another");
            GenderSelection = Convert.ToInt32(Console.ReadLine());
            switch (GenderSelection)
            {

                case 1:
                    TeachersList[IDSelection-1].PersonGender = true;
                    break;
                case 2:
                    TeachersList[IDSelection-1].PersonGender = false;
                    break;
                default:
                    throw new Exception("Incorrect input data");
            }
            Console.Write("Work Experience:");
            TeachersList[IDSelection-1].WorkExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of Subjects:");
            countOfSubjects = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subjects:");
            TeachersList[IDSelection-1].TeacherSubjects = new List<string>();
            TeachersList[IDSelection-1].TeacherSubjects.Capacity = countOfSubjects;
            for (int i = 0; i < countOfSubjects; i++)
            {
                TeachersList[IDSelection-1].TeacherSubjects.Add(Console.ReadLine());
            }
            

        }

        public void EditStudents()
        {
            Console.Write("Name:");
            StudentsList[IDSelection].FirstName = Console.ReadLine();
            Console.Write("Last name:");
            StudentsList[IDSelection].LastName = Console.ReadLine();
            Console.Write("Birth Date:");
            StudentsList[IDSelection].BirthDate = Console.ReadLine();
            Console.WriteLine("Choose person gender: 1 - Male; 2 - Female; 3 - Another");
            GenderSelection = Convert.ToInt32(Console.ReadLine());
            switch (GenderSelection)
            {
                case 1:
                    StudentsList[IDSelection].PersonGender = true;
                    break;
                case 2:
                    StudentsList[IDSelection].PersonGender = false;
                    break;
                default:
                    throw new Exception("Incorrect input data");
            }
            
            Console.Write("Gradebook number:");
            StudentsList[IDSelection].GradebookNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Course:");
            StudentsList[IDSelection].StudentСourse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Average grade:");
            StudentsList[IDSelection].AverageGrades = Convert.ToInt32(Console.ReadLine());
            
        }

        //DELETE_FUNC
        public void DeleteTeachers()
        {
            Console.Write("Enter teacher ID you want to delete:");
            IDSelection = Convert.ToInt32(Console.ReadLine());
            TeachersList.Remove(TeachersList[IDSelection-1]);
            foreach(Teacher teachers in TeachersList)
            {
                teachers.ID = TeachersList.IndexOf(teachers) + 1;
            }
            
            
        }

        public void DeleteStudents()
        {
            Console.Write("Enter student ID you want to delete:");
            IDSelection = Convert.ToInt32(Console.ReadLine());
            StudentsList.Remove(StudentsList[IDSelection-1]);
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
                if (sorted.PersonGender) {
                    SelectedGender = "Male";
                } else {
                    SelectedGender = "Female";
                }
                Console.WriteLine(
               "Last Name: " + sorted.LastName + "\n" +
               "Name: " + sorted.FirstName + "\n" +
               "Birth Date: " + sorted.BirthDate + "\n" +
               "Gender : " + SelectedGender + "\n" +
               "Student ID: " + sorted.ID + "\n" +
               "Gradebook number: " + sorted.GradebookNumber + "\n" +
               "Course: " + sorted.StudentСourse + "\n" +
               "Average grades: " + sorted.AverageGrades + "\n");
            }
        }

        //TEST TASK LISTS
        
            List<Teacher> TestTeachers = new List<Teacher>()
            {

                 new Teacher("Олег",    "Пiцун",    "21.04.1991",   true,    1, 4,       new List<string>()  {"subject1", "subject2" } ),
                 new Teacher("Богдан",  "Маслияк",  "15.07.1960",   true,    2, 14,      new List<string>()  {"subject3", "subject4" } ),
                 new Teacher("Юрiй",    "Батько",   "10.10.1980",   true,    3, 10,      new List<string>()  {"subject5", "subject6" } ),
                 new Teacher("Iгор",    "Якименко", "11.12.1970",   true,    4, 13,      new List<string>()  {"subject7", "subject8" } )
            };
        
        
           public List<Student> StandartStudents = new List<Student>
            {
                 new Student ("Валентин",    "Гарматюк",         "14.02.1998",     true  ,       1, 1,   4,     60   ),
                 new Student ("Олег",        "Момотюк",          "22.07.1998",     true  ,       2, 2,   4,     90   ),
                 new Student ("Вiталiй",     "Кухарук",          "25.08.1998",     true  ,       3, 3,   4,     60   ),
                 new Student ("Роман",       "Капустинський",    "20.06.1998",     true  ,       4, 4,   4,     85   ),
                 new Student ("Михайло",     "Хомолюк",          "10.10.1998",     true  ,       5, 5,   4,     75   ),
                 new Student ("Роман",       "Сидорчук",         "10.12.1998",     true  ,       6, 6,   4,     60   ),
                 new Student ("Зоряна",      "Щирба",            "13.05.1998",     true  ,       7, 7,   4,     89   ),
                 new Student ("Юрiй",        "Радовець",         "29.02.1997",     false ,       8, 8,   4,    100   ),
                 new Student ("Роман",       "Снєжик",           "09.03.1998",     true  ,       9, 9,   4,     95   ),
                 new Student ("Олександр",   "Коваль",           "15.09.1998",     true  ,       10, 10, 4,     77   ),

            };
            
        //OUTPUT TEST OBJECTS
        public void OutputTestTeachers()
        {
            foreach (Teacher teachers in TestTeachers)
            {
                if (teachers.PersonGender) {
                    SelectedGender = "Male";
                } else {
                    SelectedGender = "Female";
                }
                Console.WriteLine(
                "Name: " + teachers.FirstName + "\n" +
                "Last name : " + teachers.LastName + "\n" +
                "Birth date :" + teachers.BirthDate + "\n" +
                "Gender : " + SelectedGender + "\n" +
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
 