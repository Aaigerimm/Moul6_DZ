using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Constants
    {
        public const string StringConstant = "Hello!";
        public const int IntConstant = 42;
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}, Address: {person.Address}";
        }
    }
}
