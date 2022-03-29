using System;
using System.Collections.Generic;
using System.Text;

namespace Sinf_taski_3._29.Models
{
    internal class Employee : Person
    { 
        public double  Salary { get; set; }
        public string Email { get; set; }
        public Employee(double salary, string email, string name, string surname, int age) : base(name, surname, age)
        {
            Salary = salary;    
            Email = email;  
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Salary:{Salary} - Email:{Email} - Name:{Name} - SurName:{SurName} - Age:{Age}");
        }
    }
}
