﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);

    Course GetCourse(int id);
    List<Course> GetAll();
}
