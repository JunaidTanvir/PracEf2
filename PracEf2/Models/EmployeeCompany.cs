using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracEf2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int RollNo { get; set; }

        // Navigational Property


        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }

    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string place { get; set; }

        // Navigational Property

        public ICollection<Employee> Employees { get; set; }
    }
}