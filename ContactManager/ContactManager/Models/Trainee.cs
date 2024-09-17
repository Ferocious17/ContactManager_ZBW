using ContactManager.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
namespace ContactManager.Models;

/// <summary>
/// Die Klasse "Trainee" erweitert die "Employee"-Klasse und repräsentiert einen Auszubildenden.
/// Sie enthält zusätzliche Eigenschaften, die spezifisch für Auszubildende sind.
/// </summary>
public class Trainee : Employee
{
    /// <summary>
    /// Konstruktor, der alle Eigenschaften eines Auszubildenden initialisiert.
    /// Verwendet den Basis-Konstruktor der Klasse "Employee" und ergänzt spezifische Werte für Auszubildende.
    /// </summary>
    /// <param name="gender">Das Geschlecht der Person (true = männlich, false = weiblich).</param>
    /// <param name="title">Der Titel oder die Anrede der Person.</param>
    /// <param name="firstName">Der Vorname der Person.</param>
    /// <param name="lastName">Der Nachname der Person.</param>
    /// <param name="dateOfBirth">Das Geburtsdatum der Person.</param>
    /// <param name="socialSecurityNumber">Die Sozialversicherungsnummer der Person.</param>
    /// <param name="communcationInfo">Kommunikationsinformationen der Person.</param>
    /// <param name="address">Die Adresse der Person.</param>
    /// <param name="status">Der Status der Person (z.B. aktiv/inaktiv).</param>
    /// <param name="nationality">Die Nationalität der Person.</param>
    /// <param name="employeeNumber">Die eindeutige Mitarbeiternummer der Person.</param>
    /// <param name="department">Die Abteilung, in der die Person arbeitet.</param>
    /// <param name="startDate">Das Eintrittsdatum der Person.</param>
    /// <param name="endDate">Das Austrittsdatum der Person.</param>
    /// <param name="employment">Der Beschäftigungsgrad der Person (z.B. Vollzeit, Teilzeit).</param>
    /// <param name="role">Die Rolle oder Position der Person.</param>
    /// <param name="cadreLevel">Die Führungsebene der Person.</param>
    /// <param name="traineeYears">Die Gesamtanzahl der Ausbildungsjahre.</param>
    /// <param name="actualTraineeYear">Das aktuelle Ausbildungsjahr, in dem sich der Auszubildende befindet.</param>
    public Trainee(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommunicationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, Department department, DateTime startDate, DateTime endDate, int employment, string role, CadreLevel cadreLevel, int traineeYears, int actualTraineeYear)
        : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality, employeeNumber, department, startDate, endDate, employment, role, cadreLevel)
    {
        TraineeYears = traineeYears;
        ActualTraineeYear = actualTraineeYear;
    }

    /// <summary>
    /// Parameterloser Konstruktor, hauptsächlich für die Verwendung durch ORM-Systeme oder Vererbung gedacht.
    /// </summary>
    private Trainee() : base() { }

    /// <summary>
    /// Die Gesamtanzahl der Jahre, die die Ausbildung dauert.
    /// </summary>
    public int TraineeYears { get; set; }

    /// <summary>
    /// Das aktuelle Ausbildungsjahr des Auszubildenden.
    /// </summary>
    public int ActualTraineeYear { get; set; }

    /// <summary>
    /// Gibt eine CSV-Darstellung des Auszubildenden zurück, die sowohl die Basisklassen-Daten als auch spezifische Informationen für Auszubildende enthält.
    /// </summary>
    /// <returns>CSV-String des Auszubildenden.</returns>
    protected override string GetCSVRepresentation() => $"{base.GetCSVRepresentation()};{TraineeYears};{ActualTraineeYear}";
}
