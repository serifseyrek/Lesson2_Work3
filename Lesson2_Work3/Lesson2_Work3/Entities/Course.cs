using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Work3.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Instructor Instructor { get; set; }
        public decimal Price { get; set; }


        public Course(int id, string name, Instructor instructor, decimal price)
        {
            Id = id;
            Name = name;
            Instructor = instructor;
            Price = price;
        }
    }
}
