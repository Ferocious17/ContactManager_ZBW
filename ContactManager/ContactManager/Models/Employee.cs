using ContactManager.Enums;

namespace ContactManager.Models;

public class Employee : Person
{
    public Employee(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, Department department, DateTime startDate, DateTime endDate, int employment, string role, CadreLevel cadreLevel) : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality)
    {
        EmployeeNumber = employeeNumber;
        Department = department;
        StartDate = startDate;
        EndDate = endDate;
        Employment = employment;
        Role = role;
        CadreLevel = cadreLevel;
    }

    protected Employee() : base() { }

    public Guid EmployeeNumber { get; set; }
    public Department Department { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Employment { get; set; }
    public string Role { get; set; }
    public CadreLevel CadreLevel { get; set; }
}
