using ContactManager.Enums;

namespace ContactManager.Models
{
    /// <summary>
    /// Repräsentiert einen Mitarbeiter innerhalb der Organisation, der von der <see cref="Person"/>-Klasse erbt.
    /// </summary>
    /// <remarks>
    /// Die <see cref="Employee"/>-Klasse erweitert die <see cref="Person"/>-Klasse um spezifische Eigenschaften, die für Mitarbeiter relevant sind. 
    /// Diese zusätzlichen Eigenschaften umfassen eine eindeutige Mitarbeiter-ID, Abteilungszugehörigkeit, Beschäftigungsdaten, Rolle im Unternehmen und Hierarchieebene.
    /// Die Klasse bietet auch eine Methode zur CSV-Repräsentation der Mitarbeiterdaten.
    /// </remarks>
    public class Employee : Person
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Employee"/>-Klasse mit den angegebenen Werten.
        /// </summary>
        /// <param name="gender">Das Geschlecht des Mitarbeiters.</param>
        /// <param name="title">Der Titel des Mitarbeiters.</param>
        /// <param name="firstName">Der Vorname des Mitarbeiters.</param>
        /// <param name="lastName">Der Nachname des Mitarbeiters.</param>
        /// <param name="dateOfBirth">Das Geburtsdatum des Mitarbeiters.</param>
        /// <param name="socialSecurityNumber">Die Sozialversicherungsnummer des Mitarbeiters.</param>
        /// <param name="communcationInfo">Die Kommunikationsinformationen des Mitarbeiters.</param>
        /// <param name="address">Die Adresse des Mitarbeiters.</param>
        /// <param name="status">Der Status des Mitarbeiters (aktiv/inaktiv).</param>
        /// <param name="nationality">Die Nationalität des Mitarbeiters.</param>
        /// <param name="employeeNumber">Die eindeutige Mitarbeiter-ID.</param>
        /// <param name="department">Die Abteilung, in der der Mitarbeiter tätig ist.</param>
        /// <param name="startDate">Das Startdatum des Beschäftigungsverhältnisses.</param>
        /// <param name="endDate">Das Enddatum des Beschäftigungsverhältnisses, wenn vorhanden.</param>
        /// <param name="employment">Die Anzahl der Wochenarbeitsstunden des Mitarbeiters.</param>
        /// <param name="role">Die Rolle des Mitarbeiters im Unternehmen.</param>
        /// <param name="cadreLevel">Die Hierarchieebene des Mitarbeiters.</param>
        public Employee(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommunicationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, Department department, DateTime startDate, DateTime endDate, int employment, string role, CadreLevel cadreLevel)
            : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality)
        {
            EmployeeNumber = employeeNumber;
            Department = department;
            StartDate = startDate;
            EndDate = endDate;
            Employment = employment;
            Role = role;
            CadreLevel = cadreLevel;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Employee"/>-Klasse ohne Parameter.
        /// Dieser Konstruktor wird in der Regel von der Entity Framework-Bibliothek verwendet.
        /// </summary>
        internal Employee() : base()
        {
            Address = new Address();
            CommunicationInfo = new CommunicationInfo();
        }

        /// <summary>
        /// Die eindeutige ID des Mitarbeiters.
        /// </summary>
        public Guid EmployeeNumber { get; set; }

        /// <summary>
        /// Die Abteilung, in der der Mitarbeiter tätig ist.
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// Das Startdatum des Beschäftigungsverhältnisses.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Das Enddatum des Beschäftigungsverhältnisses, wenn vorhanden.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Die Anzahl der Wochenarbeitsstunden des Mitarbeiters.
        /// </summary>
        public int Employment { get; set; }

        /// <summary>
        /// Die Rolle des Mitarbeiters im Unternehmen.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Die Hierarchieebene des Mitarbeiters, die durch die <see cref="CadreLevel"/>-Enum definiert ist.
        /// </summary>
        public CadreLevel CadreLevel { get; set; }

        /// <summary>
        /// Gibt eine CSV-Repräsentation der Mitarbeiterdaten zurück.
        /// </summary>
        /// <returns>Die Mitarbeiterdaten als CSV-Format, getrennt durch Semikolons.</returns>
        protected override string GetCSVRepresentation() => $"{EmployeeNumber};{Department?.DepartmentId};{StartDate};{EndDate};{Employment};{Role};{CadreLevel}";
    }
}
