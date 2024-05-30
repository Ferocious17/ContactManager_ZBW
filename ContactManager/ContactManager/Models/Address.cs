namespace ContactManager.Models;

public class Address(string street, string streetNumber, int zipCode, string city)
{
    public string Street { get; set; } = street;
    public string StreetNumber { get; set; } = streetNumber;
    public int ZipCode { get; set; } = zipCode;
    public string City { get; set; } = city;
}
