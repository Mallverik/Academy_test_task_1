﻿using System;
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
                try
                {

                    Console.WriteLine("Output teachers: Enter \t\t\"1\"\t \t \t Delete teachers by ID: Enter \t\"7\"");
                    Console.WriteLine("Output students: Enter \t\t\"2\"\t \t \t Delete students by ID: Enter \t\"8\"");
                    Console.WriteLine("Create teachers: Enter \t\t\"3\"\t \t \t Edit teachers by ID: Enter \t\"9\"");
                    Console.WriteLine("Create students: Enter \t\t\"4\"\t \t \t Edit students by ID: Enter \t\"10\"");
                    Console.WriteLine("Output created teachers: Enter \t\"5\"\t \t \t Clean Console: Enter \t\t\"11\"");
                    Console.WriteLine("Output created studetns: Enter \t\"6\"\t \t \t Close program: Enter \t\t\"12\"");
                    string caseSwitch = Console.ReadLine();


                    switch (Convert.ToInt32(caseSwitch))
                    {
                        case 1:
                            func.Output_Teachers();
                            Console.WriteLine("Press \"Enter\" to clear continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            func.sort_students(func.standart_students);
                            Console.WriteLine("Press \"Enter\" to clear continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 3:
                            func.create_teachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 4:
                            func.create_students();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;

                        case 5:
                            func.Output_Created_Teachers();
                            Console.WriteLine("Press \"Enter\" to clear continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 6:
                            func.sort_students(func.students_L);
                            Console.WriteLine("Press \"Enter\" to clear continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 7:
                            func.delete_Teachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 8:
                            func.delete_Students();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 9:
                            func.edit_Teachers();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;
                        case 10:
                            func.edit_Students();
                            Console.Clear();
                            Console.WriteLine("Done!");
                            break;

                        case 11:
                            Console.Clear();
                            break;
                        case 12:
                            task = false;
                            break;
                    }
                }
                catch (Exception ex)
                {

                }
            }

                }
            }
            
        
            
        }
    

