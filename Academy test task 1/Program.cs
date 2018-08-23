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
            bool task = true;
            Functional func = new Functional();
             
            while (task == true)
            {
                Console.WriteLine("Output teachers: Enter \t\t\"1\"\t \t \t Delete teachers by ID: Enter \t\"7\"");
                Console.WriteLine("Output Students: Enter \t\t\"2\"\t \t \t Delete students by ID: Enter \t\"8\"");
                Console.WriteLine("Create teachers: Enter \t\t\"3\"\t \t \t Edit teachers by ID: Enter \t\"9\" in process");
                Console.WriteLine("Create students: Enter \t\t\"4\"\t \t \t Edit students by ID: Enter \t\"10\" in process");
                Console.WriteLine("Output created teachers: Enter \t\"5\"\t \t \t Clean Console: Enter \t\t\"11\"");
                Console.WriteLine("Output created studetns: Enter \t\"6\"\t \t \t Close program: Enter \t\t\"12\"");
                string caseSwitch = Console.ReadLine();


                switch (Convert.ToInt32(caseSwitch))
                {
                    case 1:
                        func.Output_Teachers();
                        break;
                    case 2:
                        func.Output_Students();
                        break;

                    case 3:
                        func.create_teachers();
                        Console.Clear();
                        break;
                    case 4:
                        func.create_students();
                        Console.Clear();
                        break;

                    case 5:
                        func.Output_Created_Teachers();
                        Console.ReadLine();
                        break;
                           
                    case 6:
                        func.Output_Created_Students();
                        Console.ReadLine();
                        break;
                    case 7:
                        func.delete_Teachers();
                        Console.ReadLine();
                        break;
                    case 8:
                        func.delete_Students();
                        Console.ReadLine();
                        break;
                    case 9:
                        func.edit_Teachers();
                        Console.ReadLine();
                        break;
                    case 10:
                        func.edit_Students();
                        Console.ReadLine();
                        break;
                        
                    case 11:
                        Console.Clear();
                        break;
                    case 12:
                        task = false;
                        break;

                }
             }
            Console.ReadLine();
        }
    }
}
