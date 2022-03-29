using System;
using System.Collections.Generic;
using System.Text;

namespace Sinf_taski_3._29.Models
{
    abstract class Person
    {
        public int Id { get;  }
        private static int _id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Person(string name,string surname,int age)
        {
            _id++;
            Id = _id;
            Name = name;    
            SurName = surname;
            Age = age;  

        }
        public abstract void ShowInfo();
    }
}
