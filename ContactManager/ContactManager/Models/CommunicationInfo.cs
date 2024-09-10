namespace ContactManager.Models;

public class CommunicationInfo
{
    public CommunicationInfo(string phoneNumberPrivate, string phoneNumberMobile, string phoneNumberBusiness, string email)
    {
        PhoneNumberPrivate = phoneNumberPrivate;
        PhoneNumberMobile = phoneNumberMobile;
        PhoneNumberBusiness = phoneNumberBusiness;
        Email = email;
    }

    internal CommunicationInfo() { }

    public string PhoneNumberPrivate { get; set; }
    public string PhoneNumberMobile { get; set; }
    public string PhoneNumberBusiness { get; set; }
    public string Email { get; set; }

    public string GetCSV() => $"{PhoneNumberPrivate};{PhoneNumberMobile};{PhoneNumberBusiness};{Email}";
}
