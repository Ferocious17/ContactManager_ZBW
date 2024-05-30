namespace ContactManager.Models;

public class Person(bool gender, string title, string firstName, string lastName, DateTime dateOfBrith, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality)
{
    public bool Gender { get; set; } = gender;
    public string Title { get; set; } = title;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public DateTime DateOfBrith { get; set; } = dateOfBrith;
    public string SocialSecurityNumber { get; set; } = socialSecurityNumber;
    public CommuncationInfo CommuncationInfo { get; set; } = communcationInfo;
    public Address Address { get; set; } = address;
    public bool Status { get; set; } = status;
    public string Nationality { get; set; } = nationality;
}
