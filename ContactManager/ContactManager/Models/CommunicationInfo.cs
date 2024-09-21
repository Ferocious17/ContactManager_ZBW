/// <summary>
/// Repräsentiert die Kommunikationsinformationen einer Person, einschließlich privater Telefonnummer, Mobilnummer, geschäftlicher Telefonnummer und E-Mail-Adresse.
/// </summary>
/// <remarks>
/// Die <see cref="CommunicationInfo"/>-Klasse speichert die verschiedenen Kommunikationsdetails einer Person. 
/// Sie umfasst private Telefonnummer, Mobilnummer, geschäftliche Telefonnummer und E-Mail-Adresse. 
/// Die Klasse bietet auch eine Methode zum Exportieren der Kommunikationsinformationen im CSV-Format.
/// </remarks>
public class CommunicationInfo
{
    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="CommunicationInfo"/>-Klasse mit den angegebenen Werten.
    /// </summary>
    /// <param name="phoneNumberPrivate">Die private Telefonnummer.</param>
    /// <param name="phoneNumberMobile">Die Mobilnummer.</param>
    /// <param name="phoneNumberBusiness">Die geschäftliche Telefonnummer.</param>
    /// <param name="email">Die E-Mail-Adresse.</param>
    public CommunicationInfo(string phoneNumberPrivate, string phoneNumberMobile, string phoneNumberBusiness, string email)
    {
        PhoneNumberPrivate = phoneNumberPrivate;
        PhoneNumberMobile = phoneNumberMobile;
        PhoneNumberBusiness = phoneNumberBusiness;
        Email = email;
    }

    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="CommunicationInfo"/>-Klasse ohne Parameter.
    /// </summary>
    internal CommunicationInfo() { }

    /// <summary>
    /// Die private Telefonnummer.
    /// </summary>
    public string PhoneNumberPrivate { get; set; }

    /// <summary>
    /// Die Mobilnummer.
    /// </summary>
    public string PhoneNumberMobile { get; set; }

    /// <summary>
    /// Die geschäftliche Telefonnummer.
    /// </summary>
    public string PhoneNumberBusiness { get; set; }

    /// <summary>
    /// Die E-Mail-Adresse.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gibt die Kommunikationsinformationen im CSV-Format zurück.
    /// </summary>
    /// <returns>Die Kommunikationsinformationen als CSV-Format, getrennt durch Semikolons.</returns>
    public string GetCSV() => $"{PhoneNumberPrivate};{PhoneNumberMobile};{PhoneNumberBusiness};{Email}";
}
