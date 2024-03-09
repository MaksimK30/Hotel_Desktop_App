using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class AccountsTabVM : ViewModelBase
{
    private List<AccountsTabRecord> _accountsList;
    private bool _isBlockedCB;
    private List<string> _searchParameters;

    public List<AccountsTabRecord> AccountsList
    {
        get { return _accountsList; }
        set { this.RaiseAndSetIfChanged(ref _accountsList, value); }
    }

    public bool IsBlockedCB
    {
        get { return _isBlockedCB; }
        set { this.RaiseAndSetIfChanged(ref _isBlockedCB, value); }
    }

    public AccountsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Account> allAccounts = dbContext.Accounts.ToList();
        List<AccountsTabRecord> accountsList = new List<AccountsTabRecord>();

        foreach (var account in allAccounts)
        {
            Passport passport = account.User.Passport;
            accountsList.Add(new AccountsTabRecord()
            {
                UserLogin = $"{passport.Lastname} {passport.Name[0]}.{passport.Patronymic[0]}",
                AccountID = account.Id.ToString(),
                IsBlocked = account.IsBlocked,
                BankCardNumber = account.BankCard.Number,
                BlockReason = account.BlockReason
            });
        }

        AccountsList = accountsList;
    }
}