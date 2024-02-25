using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.DataAccess.Concretes;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.Business;

public class InstructorManager
{
    private readonly IInstructorDal _ınstructorDal;

    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _ınstructorDal = ınstructorDal;
    }

    public List<Instructor> GetAll()
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _ınstructorDal.GetAll();
    }

    public void Add(Instructor ınstructor)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _ınstructorDal.Add(ınstructor);
    }

    public void Delete(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _ınstructorDal.Delete(id);
    }

    public Instructor GetById(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _ınstructorDal.GetById(id);
    }

    public void Update(Instructor ınstructor)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _ınstructorDal.Update(ınstructor);
    }
}
