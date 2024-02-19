﻿using Intro.Business;
using Intro.Entitites;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

// variables -> camelCase
bool isAuthenticated = true;

Console.WriteLine(message1);


// condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Damla");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; // dbden gelecek
// string[] loans2 = new string[];
// loans2[0] = "Kredi 1";

    //  start     condition     // increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "Java 17 ....";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };


for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");