namespace HotelDesktop.Models.ExtendedModels;

public class AccountsTabRecord
{
    public string AccountID { get; set; }
    
    public string UserLogin { get; set; }

    public string BankCardNumber { get; set; }

    public bool IsBlocked { get; set; }
}