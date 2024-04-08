using SinifdeYazilan.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifdeYazilan.Model
{
     class Student
    {
        static int Count = 0;
       public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surnamer)
        {
            Count++;
            Id= Count;
            Name = name.Capitalize1();
            Surname= surnamer.Capitalize1();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name : {Name}, Surname: {Surname}");
        }
    }
}
