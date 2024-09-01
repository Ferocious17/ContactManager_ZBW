namespace ContactManager.Models;

public class CommuncationInfo
{
    public CommuncationInfo(string phoneNumberPrivate, string phoneNumberMobile, string phoneNumberBusiness, string email)
    {
        PhoneNumberPrivate = phoneNumberPrivate;
        PhoneNumberMobile = phoneNumberMobile;
        PhoneNumberBusiness = phoneNumberBusiness;
        Email = email;
    }

    internal CommuncationInfo() { }

    public string PhoneNumberPrivate { get; set; }
    public string PhoneNumberMobile { get; set; }
    public string PhoneNumberBusiness { get; set; }
    public string Email { get; set; }
}
