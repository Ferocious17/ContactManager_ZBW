using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ContactManager.Models;

public class Person
{
    public Person(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommuncationInfo communicationInfo, Address address, bool status, string nationality)
    {
        Gender = gender;
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        SocialSecurityNumber = socialSecurityNumber;
        CommunicationInfo = communicationInfo;
        Address = address;
        Status = status;
        Nationality = nationality;
    }

    protected Person() { }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool Gender { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string SocialSecurityNumber { get; set; }
    public CommuncationInfo CommunicationInfo { get; set; }
    public Address Address { get; set; }
    public bool Status { get; set; }
    public string Nationality { get; set; }
}
