using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.getNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "34532634", "Math");
            teacher.getNameAndAge();

            Student student = new Student("Sara", 19, "10506", "sara123@amikom.ac.id");
            student.getNameAndAge();

            Console.ReadKey();
        }
    }
}
