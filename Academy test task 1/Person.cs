using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Academy_test_task_1
{
    enum Gender
    {
        Male,
        Female
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int ID { get; set; }
        public bool SuccesfulCreating { get; set; }
        public Gender PersonGender { get; set; }
    }
}
