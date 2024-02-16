using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager:ICourseService
    {
        private List<Course> _courses = new List<Course>();
        public CourseManager() 
        {
            _courses.Add(new Course { Id = 0,Name = "Go", Description = "Bu kurs sizi hayalinizdeki Bill Gates yapacak", Price = 10});
            _courses.Add(new Course { Id = 1, Name = "Python", Description = "Bu kurs sizi hayalinizdeki Elon Musk yapacak", Price = 10 });
        }
        public void Add(Course course)
        {
            course.Id = _courses.Count + 1;
            _courses.Add(course);
            Console.WriteLine($"{course} eklendi");
        }

        public void Delete(int id)
        {
            var deleteCourse = _courses.FirstOrDefault(c => c.Id == id);
            
            Console.WriteLine($"{deleteCourse} silindi!");
            _courses.Remove(deleteCourse);
        }

        public List<Course> GetAll()
        {
            foreach (Course course in _courses)
            {
                Console.WriteLine($"{ course.Id},{ course.Name},{ course.Description},{course.Price}");
            }
            return _courses;
        }

        public Course GetCourse(int id)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id);
            return course;
        }

        public void Update(Course course)
        {
            var newCourse = _courses.FirstOrDefault(c => c.Id == course.Id);
            newCourse.Name = course.Name;
            newCourse.Description = course.Description;
            newCourse.Price = course.Price;

        }
    }
}
