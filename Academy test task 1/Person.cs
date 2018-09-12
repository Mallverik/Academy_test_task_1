using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//через throw new передбачити виключення

//Зробити вибір гендера не через свіч кейс 
// при винекненні помилки, вертатись на той самий крок
namespace Academy_test_task_1
{
    public enum Gender : byte
    {
        Male ,
        Female ,
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int ID { get; set; }
        public Gender PersonGender { get; set; }

    }
}
