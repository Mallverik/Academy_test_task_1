using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_test_task_1
{
    public enum Gender : byte
    {
        Male ,
        Female ,
        Another 
    }
    class Person
    {
        public string name;
        public string last_name;
        public string birth_date;
        public Gender personGender { get; set; }

    }
}
