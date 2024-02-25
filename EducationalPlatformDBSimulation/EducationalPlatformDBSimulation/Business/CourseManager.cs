using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _courseDal.Add(course);
    }

    public void Delete(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _courseDal.Delete(id);
    }

    public Course GetById(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _courseDal.GetById(id);
    }

    public void Update(Course course)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _courseDal.Update(course);
    }
}
