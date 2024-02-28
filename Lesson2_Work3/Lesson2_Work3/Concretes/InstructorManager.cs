using Lesson2_Work3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Work3.Concretes
{
    public class InstructorManager
    {
        private List<Instructor> instructors;

        public InstructorManager()
        {
            instructors = new List<Instructor>();
        }

        public void AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void RemoveInstructor(string instructorId)
        {
            Instructor instructorToRemove = instructors.Find(i => i.Name == instructorId);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
            }
        }

        public List<Instructor> GetAllInstructors()
        {
            return instructors;
        }
    }

}
