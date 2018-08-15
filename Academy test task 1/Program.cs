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
                Console.WriteLine("Вивід викладачів: ВВедіть 1; \t \t \t Вивід студентів: ВВедіть 2\nОчистити консоль: Введіть 3 \t \t \t Закрити програму: Введіть 4\n");
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
