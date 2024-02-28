using Lesson2_Work3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Work3.Concretes
{
    public class CourseManager
    {

        private List<Course> courses;

        public CourseManager()
        {
            courses = new List<Course>();
        }

        // Yeni bir kurs ekler
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        // Belirli bir ID'ye sahip kursu siler
        public void RemoveCourse(int courseId)
        {
            Course courseToRemove = courses.Find(c => c.Id == courseId);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
            }
        }

        // Tüm kursları listeler
        public List<Course> GetAllCourses()
        {
            return courses;
        }

        // Belirli bir ID'ye sahip kursu getirir
        public Course GetCourseById(int courseId)
        {
            return courses.Find(c => c.Id == courseId);
        }


    }
}

