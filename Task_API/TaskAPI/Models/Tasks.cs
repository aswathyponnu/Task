using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Tasks
    {
        [Key]
        public int? TaskID { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public int? EmployeeID { get; set; }
    }
}
