namespace ContactManager.Models;

public class Address
{
    public Address(string street, string streetNumber, int zipCode, string city)
    {
        Street = street;
        StreetNumber = streetNumber;
        ZipCode = zipCode;
        City = city;
    }

    internal Address() { }

    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public int ZipCode { get; set; }
    public string City { get; set; }

    public string GetCSV() => $"{Street};{StreetNumber};{ZipCode};{City}";
}
