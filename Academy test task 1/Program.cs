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
                Console.WriteLine("Вивiд викладачiв: ВВедiть 1 \t \t \t Вивiд студентiв:  ВВедiть 2\nОчистити консоль: Введiть 3 \t \t \t Закрити програму: Введiть 4\n");
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
                        Console.Clear();
                        break;
                    case 4:
                        task = false;
                        break;

                }
            }
            
        }
    }
}
