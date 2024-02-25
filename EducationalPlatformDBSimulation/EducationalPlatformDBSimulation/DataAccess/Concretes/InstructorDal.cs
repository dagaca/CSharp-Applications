using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> ınstructors;
    public InstructorDal()
    {
        Instructor ınstructor1 = new Instructor();
        ınstructor1.Id = 1;
        ınstructor1.InstructorName = "Tümü";

        Instructor ınstructor2 = new Instructor();
        ınstructor2.Id = 2;
        ınstructor2.InstructorName = "Engin Demirog";

        Instructor ınstructor3 = new Instructor();
        ınstructor3.Id = 3;
        ınstructor3.InstructorName = "Halit Enes Kalaycı";

        ınstructors = new List<Instructor> { ınstructor1, ınstructor2, ınstructor3};
    }

    public void Add(Instructor ınstructor)
    {
        ınstructors.Add(ınstructor);
    }

    public void Delete(int id)
    {
        var ınstructorToRemove = ınstructors.FirstOrDefault(c => c.Id == id);
        if (ınstructorToRemove != null)
            ınstructors.Remove(ınstructorToRemove);
    }

    public List<Instructor> GetAll()
    {
        return ınstructors;
    }

    public Instructor GetById(int id)
    {
        return ınstructors.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Instructor ınstructor)
    {
        var existingInstructor = ınstructors.FirstOrDefault(c => c.Id == ınstructor.Id);
        if (existingInstructor != null)
        {
            existingInstructor.InstructorName = ınstructor.InstructorName;
            // Burada diğer özellikleri de güncelleyebilirsiniz.
        }
    }
}
