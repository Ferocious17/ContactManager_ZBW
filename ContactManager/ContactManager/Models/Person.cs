namespace ContactManager.Models;

public class Person(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommuncationInfo communicationInfo, Address address, bool status, string nationality)
{
    public bool Gender { get; set; } = gender;
    public string Title { get; set; } = title;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public DateTime DateOfBirth { get; set; } = dateOfBirth;
    public string SocialSecurityNumber { get; set; } = socialSecurityNumber;
    public CommuncationInfo CommunicationInfo { get; set; } = communicationInfo;
    public Address Address { get; set; } = address;
    public bool Status { get; set; } = status;
    public string Nationality { get; set; } = nationality;
}
