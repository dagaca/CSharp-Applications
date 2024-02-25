using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetById(int id); // ID'ye göre kurs getirme işlemi
        void Add(Instructor ınstructor);
        void Delete(int id); // ID'ye göre kurs silme işlemi
        void Update(Instructor ınstructor);
    }
}
