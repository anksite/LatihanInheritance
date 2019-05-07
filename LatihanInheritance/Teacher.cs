using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string Name, int Age, string TeacherId, string Subject):base(Name, Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.TeacherId = TeacherId;
            this.Subject = Subject;
        }
    }
}
