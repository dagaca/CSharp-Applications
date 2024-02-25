using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int id); // ID'ye göre kurs getirme işlemi
        void Add(Course course);
        void Delete(int id); // ID'ye göre kurs silme işlemi
        void Update(Course course);
    }
}
