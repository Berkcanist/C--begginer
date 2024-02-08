
using Intro.Business;
using Intro.Entities;

string message1 = "My name is Berkcan";

int age = 21;

Console.WriteLine("Hello, World!");


Console.WriteLine(message1);
Console.WriteLine("I'm " + age + " years old!");
Console.WriteLine("I want to be a C# programmer.");

CourseManager courseManager = new CourseManager();

Course[] courses2 = courseManager.GetAll();

for (int i = 0;i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("Kod bitti."); 