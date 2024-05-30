using ContactManager.Enums;

namespace ContactManager.Models;

public class Customer(bool gender, string title, string firstName, string lastName, DateTime dateOfBrith, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality, string companyName, CustomerType customerType, string companyContact) : Person(gender, title, firstName, lastName, dateOfBrith, socialSecurityNumber, communcationInfo, address, status, nationality)
{
    public string CompanyName { get; set; } = companyName;
    public CustomerType CustomerType { get; set; } = customerType;
    public string CompanyContact {  get; set; } = companyContact;
}
