using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category GetById(int id); // ID'ye göre kurs getirme işlemi
        void Add(Category category);
        void Delete(int id); // ID'ye göre kurs silme işlemi
        void Update(Category category);
    }
}
