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
                            ProgramFunctional.OutputTestTeachers();
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            ProgramFunctional.SortStudents(ProgramFunctional.TestStudents);
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
                            ProgramFunctional.OutputCreatedTeachers();
                            Console.WriteLine("Press \"Enter\" to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 6:
                            ProgramFunctional.SortStudents(ProgramFunctional.StudentsList);
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





    

