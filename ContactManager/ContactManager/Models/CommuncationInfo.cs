namespace ContactManager.Models;

public class CommuncationInfo(string phoneNumberPrivate, string phoneNumberMobile, string phoneNumberBusiness, string email)
{
    public string PhoneNumberPrivate { get; set; } = phoneNumberPrivate;
    public string PhoneNumberMobile { get; set; } = phoneNumberMobile;
    public string PhoneNumberBusiness { get; set; } = phoneNumberBusiness;
    public string Email { get; set; } = email;
}
