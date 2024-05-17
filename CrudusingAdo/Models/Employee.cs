using System.ComponentModel.DataAnnotations;

namespace CrudusingAdo.Models
{
    public class Employee
    {
        [Key] //this is primary key in the table
        public int Id { get; set; }
        [Required]
        public  string? Name { get; set; }//? to allow null from db
        [Required]
        public string? City { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
