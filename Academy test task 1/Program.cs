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
                Console.WriteLine("Вивiд викладачiв: ВВедiть 1 \t \t \t Вивiд студентiв:  ВВедiть 2\nОчистити консоль: Введiть 9 \t \t \t Закрити програму: Введiть 10");
                Console.WriteLine("Створити нового викладача: ВВедiть 3 \t \t  Створити нового студента:  ВВедiть 4\nВивід створених викладачів: Введiть 5 \t\t  Вивід створених студентів: Введiть 6\n");
                string caseSwitch = Console.ReadLine();


                switch (Int32.Parse(caseSwitch))
                {
                    case 1:
                        func.Output_Teachers();
                        break;
                    case 2:
                        func.Output_Students();
                        break;

                    case 3:
                        func.create_teachers();
                        
                        break;
                    case 4:
                        func.create_students();
                        break;

                    case 5:
                        {
                            func.Output_Created_Teachers();
                            break;
                            
                        }
                    case 6:
                        {
                            func.Output_Created_Students();
                            break;
                        }
                        
                    case 9:
                        Console.Clear();
                        break;
                    case 10:
                        task = false;
                        break;

                }
             }
            Console.ReadLine();
        }
    }
}
