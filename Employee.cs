using System.ComponentModel.DataAnnotations;
namespace AjayEmployeeManager.Models;
public class Employee {
 public int Id {get;set;}
 [Required, StringLength(100)] public string Name {get;set;} = "";
 [Required, EmailAddress, StringLength(150)] public string Email {get;set;} = "";
 [Required, StringLength(100)] public string Department {get;set;} = "";
 [Range(0,100000000)] public decimal Salary {get;set;}
}
