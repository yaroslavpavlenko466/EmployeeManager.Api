namespace EmployeeManager.Api.Models;
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string PersonalCode { get; set; } = "";
    public string HireDate { get; set; } = ""; //Поменять
    public float Salary { get; set; }
}