using ContactManager.Enums;
namespace ContactManager.Models;
public class Customer : Person
{

    public Customer(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommunicationInfo communcationInfo, Address address, bool status, string nationality, string companyName, CustomerType customerType, string companyContact) : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality) 
    {
        CompanyName = companyName;
        CustomerType = customerType;
        CompanyContact = companyContact;
    }

    internal Customer() : base()
    {
        Address = new();
        CommunicationInfo = new();
    }

    public string CompanyName { get; set; }
    public CustomerType CustomerType { get; set; }
    public string CompanyContact {  get; set; }
    public ICollection<Note> Notes { get; set; }

    protected override string GetCSVRepresentation() => $"{CompanyName};{CustomerType};{CompanyContact}";
}
