using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Employee
    {
        [Key]
        public int? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeCode { get; set; }
    }
}
