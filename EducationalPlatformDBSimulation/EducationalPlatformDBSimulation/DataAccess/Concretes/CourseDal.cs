using EducationalPlatformDBSimulation.DataAccess.Abstracts;
using EducationalPlatformDBSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatformDBSimulation.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.CourseName = "Programlamaya Giriş için Temel Kurs";
        course1.Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır...";
        course1.InstructorName = "Engin Demirog";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
        course2.Description = " ";
        course2.InstructorName = "Engin Demirog";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA - REACT)";
        course3.Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını...";
        course3.InstructorName = "Engin Demirog";
        course3.Price = 0;

        Course course4 = new Course();
        course4.Id = 4;
        course4.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
        course4.Description = " ";
        course4.InstructorName = "Engin Demirog";
        course4.Price = 0;

        Course course5 = new Course();
        course5.Id = 5;
        course5.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
        course5.Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan...";
        course5.InstructorName = "Engin Demirog";
        course5.Price = 0;

        Course course6 = new Course();
        course6.Id = 6;
        course6.CourseName = "2023 Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
        course6.Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını...";
        course6.InstructorName = "Engin Demirog";
        course6.Price = 0;

        Course course7 = new Course();
        course7.Id = 7;
        course7.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# - ANGULAR)";
        course7.Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını...";
        course7.InstructorName = "Engin Demirog";
        course7.Price = 0;

        Course course8 = new Course();
        course8.Id = 8;
        course8.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
        course8.Description = " ";
        course8.InstructorName = "Engin Demirog";
        course8.Price = 0;

        courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(int id)
    {
        var courseToRemove = courses.FirstOrDefault(c => c.Id == id);
        if (courseToRemove != null)
            courses.Remove(courseToRemove);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int id)
    {
        return courses.FirstOrDefault(c => c.Id == id);
    }

    public void Update(Course course)
    {
        var existingCourse = courses.FirstOrDefault(c => c.Id == course.Id);
        if (existingCourse != null)
        {
            existingCourse.CourseName = course.CourseName;
            // Burada diğer özellikleri de güncelleyebilirsiniz.
        }
    }
}
