using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Work3.Entities
{
    public class Instructor
    {
        public string Name { get; set; }
       public string LastName { get; set; }
        public Instructor(string name , string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
    
}
