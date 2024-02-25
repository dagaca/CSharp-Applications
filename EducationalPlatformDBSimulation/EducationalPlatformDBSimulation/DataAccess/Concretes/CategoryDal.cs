using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;
    public CategoryDal()
    {
        Category category1 = new Category();
        category1.Id = 1;
        category1.CategoryName = "Tümü";

        Category category2 = new Category();
        category2.Id = 2;
        category2.CategoryName = "Programlama";

        categories = new List<Category> { category1, category2 };
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(int id)
    {
        var categoryToRemove = categories.FirstOrDefault(c => c.Id == id);
        if (categoryToRemove != null)
            categories.Remove(categoryToRemove);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
        return categories.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Category category)
    {
        var existingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
        if (existingCategory != null)
        {
            existingCategory.CategoryName = category.CategoryName;
            // Burada diğer özellikleri de güncelleyebilirsiniz.
        }
    }
}
