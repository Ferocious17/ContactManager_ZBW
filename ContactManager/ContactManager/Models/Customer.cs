using ContactManager.Enums;

namespace ContactManager.Models
{
    /// <summary>
    /// Repräsentiert einen Kunden, der von der <see cref="Person"/>-Klasse erbt und zusätzliche Informationen wie Unternehmensname, Kundentyp und Firmenkontakt enthält.
    /// </summary>
    /// <remarks>
    /// Die <see cref="Customer"/>-Klasse erweitert die <see cref="Person"/>-Klasse um spezifische Eigenschaften, die für Kunden relevant sind. 
    /// Diese zusätzlichen Informationen umfassen den Unternehmensnamen, den Typ des Kunden, den Firmenkontakt und eine Sammlung von Notizen.
    /// Die Klasse bietet auch eine Methode zur CSV-Repräsentation von kundenbezogenen Informationen.
    /// </remarks>
    public class Customer : Person
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Customer"/>-Klasse mit den angegebenen Werten.
        /// </summary>
        /// <param name="gender">Das Geschlecht des Kunden.</param>
        /// <param name="title">Der Titel des Kunden.</param>
        /// <param name="firstName">Der Vorname des Kunden.</param>
        /// <param name="lastName">Der Nachname des Kunden.</param>
        /// <param name="dateOfBirth">Das Geburtsdatum des Kunden.</param>
        /// <param name="socialSecurityNumber">Die Sozialversicherungsnummer des Kunden.</param>
        /// <param name="communcationInfo">Die Kommunikationsinformationen des Kunden.</param>
        /// <param name="address">Die Adresse des Kunden.</param>
        /// <param name="status">Der Status des Kunden (aktiv/inaktiv).</param>
        /// <param name="nationality">Die Nationalität des Kunden.</param>
        /// <param name="companyName">Der Name des Unternehmens, bei dem der Kunde beschäftigt ist.</param>
        /// <param name="customerType">Der Typ des Kunden.</param>
        /// <param name="companyContact">Der Kontakt für das Unternehmen des Kunden.</param>
        public Customer(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommunicationInfo communcationInfo, Address address, bool status, string nationality, string companyName, CustomerType customerType, string companyContact)
            : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality)
        {
            CompanyName = companyName;
            CustomerType = customerType;
            CompanyContact = companyContact;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Customer"/>-Klasse ohne Parameter.
        /// </summary>
        internal Customer() : base()
        {
            Address = new Address();
            CommunicationInfo = new CommunicationInfo();
        }

        /// <summary>
        /// Der Name des Unternehmens, bei dem der Kunde beschäftigt ist.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Der Typ des Kunden, der durch die <see cref="CustomerType"/>-Enum definiert ist.
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Der Kontakt für das Unternehmen des Kunden.
        /// </summary>
        public string CompanyContact { get; set; }

        /// <summary>
        /// Eine Sammlung von Notizen, die dem Kunden zugeordnet sind.
        /// </summary>
        public ICollection<Note> Notes { get; set; }

        /// <summary>
        /// Gibt eine CSV-Repräsentation der kundenbezogenen Informationen zurück.
        /// </summary>
        /// <returns>Die kundenbezogenen Informationen als CSV-Format, getrennt durch Semikolons.</returns>
        protected override string GetCSVRepresentation() => $"{CompanyName};{CustomerType};{CompanyContact}";
    }
}
