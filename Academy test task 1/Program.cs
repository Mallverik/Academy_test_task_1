using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Academy_test_task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            bool TaskIsRunning = true;
            Functional ProgramFunctional = new Functional();

            while (TaskIsRunning)
            {
                try
                {

                    Console.Clear();
                    Console.WriteLine("Output test teachers: \t\"1\"\t \t \t \t Delete teachers by ID: \"7\"");
                    Console.WriteLine("Output test students:  \t\"2\"\t \t \t \t Delete students by ID: \"8\"");
                    Console.WriteLine("Create teachers:  \t\"3\"\t \t \t\t Edit teachers by ID: \t\"9\"");
                    Console.WriteLine("Create students:  \t\"4\"\t \t \t\t Edit students by ID: \t\"10\"");
                    Console.WriteLine("Output created teachers:\"5\"\t \t\t \t Clean Console: \t\"11\"");
                    Console.WriteLine("Output created studetns:\"6\"\t \t\t \t Close program: \t\"12\"");
                    int caseSwitch = Convert.ToInt32(Console.ReadLine());


                    switch (caseSwitch)
                    {

                        case 1:
                            List<Teacher> TestTeachers = new List<Teacher>()
                            {

                                new Teacher("Олег",    "Пiцун",    "21.04.1991",   true,    1, 4,       new List<string>()  {"subject1", "subject2" } ),
                                new Teacher("Богдан",  "Маслияк",  "15.07.1960",   true,    2, 14,      new List<string>()  {"subject3", "subject4" } ),
                                new Teacher("Юрiй",    "Батько",   "10.10.1980",   true,    3, 10,      new List<string>()  {"subject5", "subject6" } ),
                                new Teacher("Iгор",    "Якименко", "11.12.1970",   true,    4, 13,      new List<string>()  {"subject7", "subject8" } )
                            };
                            ProgramFunctional.OutputTeachers(TestTeachers);
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            List<Student> TestStudents = new List<Student>
                            {
                                new Student ("Валентин",    "Гарматюк",         "14.02.1998",     true  ,       1, 1,   4,     60   ),
                                new Student ("Олег",        "Момотюк",          "22.07.1998",     true  ,       2, 2,   4,     90   ),
                                new Student ("Вiталiй",     "Кухарук",          "25.08.1998",     true  ,       3, 3,   4,     60   ),
                                new Student ("Роман",       "Капустинський",    "20.06.1998",     true  ,       4, 4,   4,     85   ),
                                new Student ("Михайло",     "Хомолюк",          "10.10.1998",     true  ,       5, 5,   4,     75   ),
                                new Student ("Роман",       "Сидорчук",         "10.12.1998",     true  ,       6, 6,   4,     60   ),
                                new Student ("Зоряна",      "Щирба",            "13.05.1998",     false ,       7, 7,   4,     89   ),
                                new Student ("Юрiй",        "Радовець",         "29.02.1997",     false ,       8, 8,   4,    100   ),
                                new Student ("Роман",       "Снєжик",           "09.03.1998",     true  ,       9, 9,   4,     95   ),
                                new Student ("Олександр",   "Коваль",           "15.09.1998",     true  ,       10, 10, 4,     77   ),

                            };
                            ProgramFunctional.OutputSortedStudents(TestStudents);
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 3:
                            ProgramFunctional.CreateTeachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 4:
                            ProgramFunctional.CreateStudents();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;

                        case 5:
                            ProgramFunctional.OutputTeachers(ProgramFunctional.TeachersList);
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 6:
                            ProgramFunctional.OutputSortedStudents(ProgramFunctional.StudentsList);
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 7:
                            ProgramFunctional.DeleteTeachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 8:
                            ProgramFunctional.DeleteStudents();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 9:
                            ProgramFunctional.EditTeachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 10:
                            ProgramFunctional.EditStudents();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;

                        case 11:
                            Console.Clear();
                            break;
                        case 12:
                            TaskIsRunning = false;
                            break;
                    }
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press \"Enter\" to continue ");
                    Console.ReadLine();

                }
            }

        }
    }
}





    

