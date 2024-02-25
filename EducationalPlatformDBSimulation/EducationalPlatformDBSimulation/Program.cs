using EducationalPlatformDBSimulation.Business;
using EducationalPlatformDBSimulation.DataAccess.Concretes;
using EducationalPlatformDBSimulation.Entities;

// Veritabanında bulunan kursları listeleme
CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();
Console.WriteLine("Tüm Kurslar:");
foreach (var course in courses)
{
    Console.WriteLine($"ID: {course.Id}, Kurs Adı: {course.CourseName}, Açıklama: {course.Description}");
}

// Yeni bir kurs eklemek için bir ID belirleme
int nextCourseId = courses.Count > 0 ? courses.Max(c => c.Id) + 1 : 1;

// Yeni bir kurs oluşturma ve ekleme
Course newCourse = new Course { Id = nextCourseId, CourseName = "Yeni Kurs", Description = "Yeni kurs açıklaması" };
courseManager.Add(newCourse);
Console.WriteLine($"Yeni eklenen kurs: ID: {newCourse.Id}, Kurs Adı: {newCourse.CourseName}, Açıklama: {newCourse.Description}");

// Güncellenmiş kursu alıp güncelleme
Course courseToUpdate = courseManager.GetById(newCourse.Id);
if (courseToUpdate != null)
{
    courseToUpdate.CourseName = "Güncellenmiş Kurs";
    courseToUpdate.Description = "Güncellenmiş kurs açıklaması";
    courseManager.Update(courseToUpdate);
    Console.WriteLine($"Güncellenmiş kurs: ID: {courseToUpdate.Id}, Kurs Adı: {courseToUpdate.CourseName}, Açıklama: {courseToUpdate.Description}");
}

// Kursu silme
int courseIdToDelete = 1; // Silinecek kursun ID'si
courseManager.Delete(courseIdToDelete);
Console.WriteLine($"Kurs silindi. ID: {courseIdToDelete}");

// Silinen kursu kontrol etme
Course deletedCourse = courseManager.GetById(courseIdToDelete);
if (deletedCourse == null)
{
    Console.WriteLine("Belirtilen ID'ye sahip kurs bulunamadı, başarıyla silinmiş olabilir.");
}
else
{
    Console.WriteLine("Kurs silinirken bir hata oluştu.");
}

// Tüm kursları güncellenmiş olarak ekrana yazdırma
List<Course> updatedCourses = courseManager.GetAll();
Console.WriteLine("Güncellenmiş Kurslar:");
foreach (var updatedCourse in updatedCourses)
{
    Console.WriteLine($"ID: {updatedCourse.Id}, Kurs Adı: {updatedCourse.CourseName}, Açıklama: {updatedCourse.Description}");
}

Console.WriteLine("//****************************************************************************************//");

// Eğitmenleri listeleme
InstructorManager instructorManager = new InstructorManager(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();
Console.WriteLine("Tüm Eğitmenler:");
foreach (var instructor in instructors)
{
    Console.WriteLine($"ID: {instructor.Id}, Eğitmen Adı: {instructor.InstructorName}");
}

// Yeni eğitmenler ekleyerek
for (int i = 1; i <= 3; i++)
{
    int nextInstructorId = instructors.Count > 0 ? instructors.Max(i => i.Id) + 1 : 1;
    Instructor newInstructor = new Instructor { Id = nextInstructorId, InstructorName = $"Yeni Eğitmen {i}" };
    instructorManager.Add(newInstructor);
    Console.WriteLine($"Yeni eklenen eğitmen: ID: {newInstructor.Id}, Eğitmen Adı: {newInstructor.InstructorName}");
}

// İlk iki eklenen eğitmenleri güncelleme
for (int i = 1; i <= 2; i++)
{
    int instructorIdToUpdate = instructors.Count - i + 1;
    Instructor instructorToUpdate = instructorManager.GetById(instructorIdToUpdate);
    if (instructorToUpdate != null)
    {
        instructorToUpdate.InstructorName = $"Güncellenmiş Eğitmen {i}";
        instructorManager.Update(instructorToUpdate);
        Console.WriteLine($"Güncellenmiş eğitmen: ID: {instructorToUpdate.Id}, Eğitmen Adı: {instructorToUpdate.InstructorName}");
    }
}

// Bir eğitmeni silme
int instructorIdToDelete = 1; // Silinecek eğitmenin ID'si
instructorManager.Delete(instructorIdToDelete);
Console.WriteLine($"Eğitmen silindi. ID: {instructorIdToDelete}");

// Tüm eğitmenleri güncellenmiş olarak ekrana yazdırma
List<Instructor> updatedInstructors = instructorManager.GetAll();
Console.WriteLine("Güncellenmiş Eğitmenler:");
foreach (var updatedInstructor in updatedInstructors)
{
    Console.WriteLine($"ID: {updatedInstructor.Id}, Eğitmen Adı: {updatedInstructor.InstructorName}");
}

Console.WriteLine("//****************************************************************************************//");

// Kategorileri listeleme
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
Console.WriteLine("Tüm Kategoriler:");
foreach (var category in categories)
{
    Console.WriteLine($"ID: {category.Id}, Kategori Adı: {category.CategoryName}");
}

// Yeni kategoriler ekleyerek
for (int i = 1; i <= 5; i++)
{
    int nextCategoryId = categories.Count > 0 ? categories.Max(c => c.Id) + 1 : 1;
    Category newCategory = new Category { Id = nextCategoryId, CategoryName = $"Yeni Kategori {i}" };
    categoryManager.Add(newCategory);
    Console.WriteLine($"Yeni eklenen kategori: ID: {newCategory.Id}, Kategori Adı: {newCategory.CategoryName}");
}

// İlk iki eklenen kategorileri silme
for (int i = 1; i <= 2; i++)
{
    int categoryIdToDelete = categories.Count - i + 1;
    categoryManager.Delete(categoryIdToDelete);
    Console.WriteLine($"Kategori silindi. ID: {categoryIdToDelete}");
}

// Bir kategoriyi güncelleme
int categoryIdToUpdate = 3; // Güncellenecek kategorinin ID'si
Category categoryToUpdate = categoryManager.GetById(categoryIdToUpdate);
if (categoryToUpdate != null)
{
    categoryToUpdate.CategoryName = "Güncellenmiş Kategori";
    categoryManager.Update(categoryToUpdate);
    Console.WriteLine($"Güncellenmiş kategori: ID: {categoryToUpdate.Id}, Kategori Adı: {categoryToUpdate.CategoryName}");
}

// Tüm kategorileri güncellenmiş olarak ekrana yazdırma
List<Category> updatedCategories = categoryManager.GetAll();
Console.WriteLine("Güncellenmiş Kategoriler:");
foreach (var updatedCategory in updatedCategories)
{
    Console.WriteLine($"ID: {updatedCategory.Id}, Kategori Adı: {updatedCategory.CategoryName}");
}