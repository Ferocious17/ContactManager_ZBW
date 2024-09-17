using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ContactManager.Models;

/// <summary>
/// Die abstrakte Klasse "Person" stellt ein Modell für eine Person dar. 
/// Sie enthält allgemeine Eigenschaften, die eine Person beschreiben, 
/// und ist zur Vererbung durch andere Klassen gedacht.
/// </summary>
public abstract class Person
{
    /// <summary>
    /// Konstruktor, der alle notwendigen Eigenschaften einer Person initialisiert.
    /// </summary>
    /// <param name="gender">Das Geschlecht der Person (true = männlich, false = weiblich).</param>
    /// <param name="title">Der Titel oder die Anrede der Person.</param>
    /// <param name="firstName">Der Vorname der Person.</param>
    /// <param name="lastName">Der Nachname der Person.</param>
    /// <param name="dateOfBirth">Das Geburtsdatum der Person.</param>
    /// <param name="socialSecurityNumber">Die Sozialversicherungsnummer der Person.</param>
    /// <param name="communicationInfo">Kommunikationsinformationen der Person.</param>
    /// <param name="address">Die Adresse der Person.</param>
    /// <param name="status">Der Status der Person (z.B. aktiv/inaktiv).</param>
    /// <param name="nationality">Die Nationalität der Person.</param>
    public Person(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommunicationInfo communicationInfo, Address address, bool status, string nationality)
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

    /// <summary>
    /// Parameterloser Konstruktor zum Erstellen einer leeren Person.
    /// Wird hauptsächlich für die Vererbung und ORM (z.B. Entity Framework) verwendet.
    /// </summary>
    protected Person() { }

    /// <summary>
    /// Eindeutige ID der Person, wird automatisch generiert.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Geschlecht der Person (true = männlich, false = weiblich).
    /// </summary>
    public bool Gender { get; set; }

    /// <summary>
    /// Titel oder Anrede der Person.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Vorname der Person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Nachname der Person.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Geburtsdatum der Person.
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Sozialversicherungsnummer der Person.
    /// </summary>
    public string SocialSecurityNumber { get; set; }

    /// <summary>
    /// Kommunikationsinformationen der Person (Telefon, E-Mail etc.).
    /// </summary>
    public CommunicationInfo CommunicationInfo { get; set; }

    /// <summary>
    /// Adresse der Person.
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Status der Person (z.B. aktiv/inaktiv).
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    /// Nationalität der Person.
    /// </summary>
    public string Nationality { get; set; }

    /// <summary>
    /// Gibt die CSV-Darstellung der Person zurück, basierend auf den Eigenschaften.
    /// Die spezifische Darstellung für abgeleitete Klassen wird über die Methode GetCSVRepresentation() ergänzt.
    /// </summary>
    /// <returns>CSV-String der Person.</returns>
    public string GetCSV() => $"{GetType().Name};{Gender};{Title};{FirstName};{LastName};{DateOfBirth};{SocialSecurityNumber};{CommunicationInfo.GetCSV()};{Address.GetCSV()};{Status};{Nationality};{GetCSVRepresentation()}";

    /// <summary>
    /// Abstrakte Methode, die von abgeleiteten Klassen implementiert werden muss, um eine CSV-spezifische Darstellung zu erzeugen.
    /// </summary>
    /// <returns>CSV-Darstellung, die von abgeleiteten Klassen bereitgestellt wird.</returns>
    protected abstract string GetCSVRepresentation();
}
