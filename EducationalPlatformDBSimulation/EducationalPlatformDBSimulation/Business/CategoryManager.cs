using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.Business;

public class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _categoryDal.Delete(id);
    }

    public Category GetById(int id)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        return _categoryDal.GetById(id);
    }

    public void Update(Category category)
    {
        // İş mantığı kurallarını burada uygula (isteğe bağlı)

        _categoryDal.Update(category);
    }
}
