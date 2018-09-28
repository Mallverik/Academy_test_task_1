﻿using System;
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
            int countOfSubjects;

            try
            {

                if (TeachersList.Capacity == 0)
                {
                    TeachersList.Add(new Teacher());
                }


                foreach (Teacher teachers in TeachersList)
                {
                    if (!teachers.SuccesfulCreating)
                    {
                        Console.WriteLine("Enter teacher with ID:" + (TeachersList.IndexOf(teachers) + 1));
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
                                throw new Exception("Incorrect input data");
                        }

                        Console.Write("Work Experience:");
                        teachers.WorkExperience = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Count of Subjects:");
                        countOfSubjects = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Subjects:");
                        teachers.TeacherSubjects = new List<string>
                        {
                            Capacity = countOfSubjects
                        };

                        for (int i = 0; i < countOfSubjects; i++)
                        {
                            teachers.TeacherSubjects.Add(Console.ReadLine());
                        }
                        teachers.ID = TeachersList.IndexOf(teachers) + 1;
                        teachers.SuccesfulCreating = true;
                    }
                }
                TeachersList.Add(new Teacher());
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message + "\nTry again ");
                CreateTeachers();
            }
        }

        public void CreateStudents()
        {
            if (StudentsList.Capacity == 0)
            {
                StudentsList.Add(new Student());
            }

            try
            {
                foreach (Student students in StudentsList)
                {
                    if (!students.SuccesfulCreating)
                    {
                        Console.WriteLine("Enter student with ID:" + (StudentsList.IndexOf(students) + 1));
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

                        Console.Write("Gradebook number:");
                        students.GradebookNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Course:");
                        students.StudentСourse = Convert.ToInt32(Console.ReadLine());
                        if (students.StudentСourse <= 0)
                        {
                            throw new Exception("Incorrect input data");
                        }
                        Console.Write("Average grade:");
                        students.AverageGrades = Convert.ToInt32(Console.ReadLine());
                        if (students.AverageGrades <= 0 || students.AverageGrades >= 100)
                        {
                            throw new Exception("Incorrect input data");
                        }
                        students.ID = StudentsList.IndexOf(students) + 1;
                        students.SuccesfulCreating = true;
                    }
                }
                StudentsList.Add(new Student());
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message + "\nTry again:");
                CreateStudents();
            }

        }

        //EDIT
        public void EditTeachers()
        {
            Console.Write("Enter teacher ID you want to edit:");
            IDSelection = Convert.ToInt32(Console.ReadLine());
            int countOfSubjects;

            Console.Write("Name:");
            TeachersList[IDSelection - 1].FirstName = Console.ReadLine();
            Console.Write("Last name:");
            TeachersList[IDSelection - 1].LastName = Console.ReadLine();
            Console.Write("Birth Date:");
            TeachersList[IDSelection - 1].BirthDate = Console.ReadLine();
            Console.WriteLine("Choose person gender: 1 - Male; 2 - Female; 3 - Another");
            GenderSelection = Convert.ToInt32(Console.ReadLine());
            switch (GenderSelection)
            {

                case 1:
                    TeachersList[IDSelection - 1].PersonGender = true;
                    break;
                case 2:
                    TeachersList[IDSelection - 1].PersonGender = false;
                    break;
                default:
                    throw new Exception("Incorrect input data");
            }
            Console.Write("Work Experience:");
            TeachersList[IDSelection - 1].WorkExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of Subjects:");
            countOfSubjects = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subjects:");
            TeachersList[IDSelection - 1].TeacherSubjects = new List<string>();
            TeachersList[IDSelection - 1].TeacherSubjects.Capacity = countOfSubjects;
            for (int i = 0; i < countOfSubjects; i++)
            {
                TeachersList[IDSelection - 1].TeacherSubjects.Add(Console.ReadLine());
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
            if (StudentsList[IDSelection].StudentСourse <= 0)
            {
                throw new Exception("Incorect input data");
            }
            Console.Write("Average grade:");
            StudentsList[IDSelection].AverageGrades = Convert.ToInt32(Console.ReadLine());
            if (StudentsList[IDSelection].AverageGrades <= 0 || StudentsList[IDSelection].AverageGrades > 100)
            {
                throw new Exception("Incorect input data");
            }

        }

        //DELETE_FUNC
        public void DeleteTeachers()
        {
            Console.Write("Enter teacher ID you want to delete:");
            IDSelection = Convert.ToInt32(Console.ReadLine());
            TeachersList.Remove(TeachersList[IDSelection - 1]);
            foreach (Teacher teachers in TeachersList)
            {
                teachers.ID = TeachersList.IndexOf(teachers) + 1;
            }


        }

        public void DeleteStudents()
        {
            Console.Write("Enter student ID you want to delete:");
            IDSelection = Convert.ToInt32(Console.ReadLine());
            StudentsList.Remove(StudentsList[IDSelection - 1]);
            foreach (Student students in StudentsList)
            {
                students.ID = StudentsList.IndexOf(students) + 1;
            }

        }
     
        //OUTPUT
        public void OutputTeachers(List<Teacher> OutputTeachers)
        {
            StringBuilder OutputStringBuilder = new StringBuilder();
            foreach (Teacher teachers in OutputTeachers)
            {
                if (teachers.ID != 0)
                {
                    if (teachers.PersonGender)
                    {
                        SelectedGender = "Male";
                    }
                    else
                    {
                        SelectedGender = "Female";
                    }

                    OutputStringBuilder.Append(
                        $"\nName: { teachers.FirstName} \nLast name: {teachers.LastName} \nBirth Date: {teachers.BirthDate} " +
                        $"\nGender: {SelectedGender} \nTeacher ID: {teachers.ID} \nWork Experience: {teachers.WorkExperience} \nSubjects list:\n");
                    foreach (var subjects in teachers.TeacherSubjects)
                    {
                        OutputStringBuilder.Append($"{subjects}\n");
                    }
                }

            }
            Console.WriteLine(OutputStringBuilder + "\n");
        }

        //SORTED STUDENTS
        public void OutputSortedStudents(List<Student> SortStudentsList)
        {
            StringBuilder OutputStringBuilder = new StringBuilder();
            var students = SortStudentsList.OrderBy(sorted => sorted.LastName);

            foreach (Student sorted in students)
            {
                if (sorted.ID != 0)
                {
                    if (sorted.PersonGender)
                    {
                        SelectedGender = "Male";
                    }
                    else
                    {
                        SelectedGender = "Female";
                    }
                    OutputStringBuilder.Append(
                        $"\nLast Name: {sorted.LastName} \nFirst Name: {sorted.FirstName} \nBirth Date: {sorted.BirthDate} \nGender: {SelectedGender}" +
                        $"\nStudent ID: {sorted.ID} \nGradebook: {sorted.GradebookNumber} \nCourse: {sorted.StudentСourse} \nAverage grades: {sorted.AverageGrades}\n");
                }

            }
            Console.WriteLine($"{OutputStringBuilder}\n");
        }
    }
}