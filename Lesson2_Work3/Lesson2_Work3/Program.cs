// See https://aka.ms/new-console-template for more information
using Lesson2_Work3.Concretes;
using Lesson2_Work3.Entities;

Console.WriteLine("Hello, World!");



// Instructors oluşturuluyor
Instructor instructor1 = new Instructor("Engin", "Demiroğ");
Instructor instructor2 = new Instructor("Halit Enes", "Kalaycı");


// CourseManager örneği oluşturuluyor
CourseManager courseManager = new CourseManager();

// CourseManager üzerinden kurslar ekleniyor
courseManager.AddCourse(new Course(1, "C# Programming",instructor1, 0));
courseManager.AddCourse(new Course(2, "ASP.NET Core Development", instructor2, 130));

// Tüm kurslar alınıyor ve listeleniyor
List<Course> allCourses = courseManager.GetAllCourses();
foreach (Course course in allCourses)
{
    Console.WriteLine($"Course ID: {course.Id}");
    Console.WriteLine($"Name: {course.Name}");
    Console.WriteLine($"Instructor: {course.Instructor}");
    Console.WriteLine($"Price: {course.Price:C}"); // Currency format kullanılıyor
    Console.WriteLine();
}