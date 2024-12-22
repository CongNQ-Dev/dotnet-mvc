using System.ComponentModel.DataAnnotations;

namespace University.Models;

public class Student
{
    [Key] public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName => $"{FirstName} {MiddleName} {LastName}";
    public string EmalAddress { get; set; } = null!;
    public int PhoneNumber { get; set; }
    public string Gender { get; set; } = null!;
}