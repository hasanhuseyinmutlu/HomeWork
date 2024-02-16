using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private List<Instructor> _instructors = new List<Instructor>();
        public InstructorManager() 
        {
            _instructors.Add(new Instructor {Id = 0, FirstName = "Hasan", LastName = "Mutlu", Description = "Merhabalar ben ibrahim yilmaz instagramda 15 milyon takipcim var" });
        }
        public void Add(Instructor instructor)
        {
            instructor.Id = _instructors.Count + 1;
            _instructors.Add(instructor);
            Console.WriteLine($"{instructor} eklendi");
        }

        public void Delete(Instructor instructor)
        {
           var deleteInstructor = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            _instructors.Remove(deleteInstructor);
            Console.WriteLine($"{deleteInstructor}  silindi");
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine($"{instructor.Id},{instructor.FirstName},{instructor.LastName},{instructor.Description}");
            }
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            var newCourse = _instructors.FirstOrDefault(i =>i.Id == instructor.Id);
            newCourse.FirstName = instructor.FirstName;
            newCourse.LastName = instructor.LastName;
            newCourse.Description = instructor.Description;
            
        }
    }
}
