﻿namespace ContactManager.Models;

public class Employee(bool gender, string title, string firstName, string lastName, DateTime dateOfBrith, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, string department, DateTime startDate, DateTime endDate, int employment, string role, int cadreLevel) : Person(gender, title, firstName, lastName, dateOfBrith, socialSecurityNumber, communcationInfo, address, status, nationality)
{
    public Guid EmployeeNumber { get; set; } = employeeNumber;
    public string Department { get; set; } = department;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public int Employment { get; set; } = employment;
    public string Role { get; set; } = role;
    public int CadreLevel { get; set; } = cadreLevel;
}
