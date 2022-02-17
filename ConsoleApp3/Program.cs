using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ismayil","Ismayiov","Sun",70);
            Console.WriteLine(student.FullName());
            Console.WriteLine(student.TakeExame());

            
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;


        public Student(string name, string surname, string group, int point, bool isGraduated=false)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
       
        }
        public string FullName()
        {
           return $"Name:{Name}\nSurname:{Surname}";
            
        }
        public string GetInfo()
        {
            string Info = $"Name:{Name} Surname:{Surname} Group:{Group} Point:{Point}\n";
            if (IsGraduated)
            {
                return Info + "Bu telebe mezun olub";
            }
            else
            {
                return Info + "Bu telebe mezun olmayib";
            }
        }
        public string TakeExame()
        {
            if (Point > 80 && Point < 100)
            {
                return "Bu telebe imtahana gire biler";
            }
            else
            {
                return "Imtahani unut";
            }
        }
    }
    

}
