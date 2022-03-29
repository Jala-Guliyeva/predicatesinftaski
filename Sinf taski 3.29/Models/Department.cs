using System;
using System.Collections.Generic;
using System.Text;

namespace Sinf_taski_3._29.Models
{
    internal class Department
    {
        public int EmployeeLimit { get; set; }
        private List<Employee> employees;

        
        private Predicate<Employee> predicate = (n) =>
        {
            return true;
        };  

        public void AddEmployee()
        {

        }
    }
}
