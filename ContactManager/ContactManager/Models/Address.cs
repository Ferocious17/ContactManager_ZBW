/// <summary>
/// Repräsentiert eine physische Adresse mit Straßennamen, Hausnummer, Postleitzahl und Stadt.
/// </summary>
/// <remarks>
/// Die <see cref="Address"/>-Klasse wird verwendet, um eine Adresse zu modellieren, die aus vier Hauptkomponenten besteht: 
/// Straßenname, Hausnummer, Postleitzahl und Stadt. Sie bietet eine Methode zum Exportieren der Adresse als CSV-Format.
/// </remarks>
public class Address
{
    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="Address"/>-Klasse mit den angegebenen Werten.
    /// </summary>
    /// <param name="street">Der Name der Straße.</param>
    /// <param name="streetNumber">Die Hausnummer.</param>
    /// <param name="zipCode">Die Postleitzahl.</param>
    /// <param name="city">Die Stadt.</param>
    public Address(string street, string streetNumber, int zipCode, string city)
    {
        Street = street;
        StreetNumber = streetNumber;
        ZipCode = zipCode;
        City = city;
    }

    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="Address"/>-Klasse ohne Parameter.
    /// </summary>
    internal Address() { }

    /// <summary>
    /// Der Name der Straße.
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Die Hausnummer.
    /// </summary>
    public string StreetNumber { get; set; }

    /// <summary>
    /// Die Postleitzahl.
    /// </summary>
    public int ZipCode { get; set; }

    /// <summary>
    /// Die Stadt.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gibt die Adresse im CSV-Format zurück.
    /// </summary>
    /// <returns>Die Adresse als CSV-Format, getrennt durch Semikolons.</returns>
    public string GetCSV() => $"{Street};{StreetNumber};{ZipCode};{City}";
}
