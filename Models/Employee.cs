using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagement.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Department { get; set; }
        public string Designation { get; set; }
    }
}
