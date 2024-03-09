using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class BankCardsTabVM : ViewModelBase
{
    private List<BankCardsTabRecord> _bankCardsList;

    public List<BankCardsTabRecord> BankCardsList
    {
        get { return _bankCardsList; }
        set { this.RaiseAndSetIfChanged(ref _bankCardsList, value); }
    }

    public BankCardsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<BankCard> allBankCards = dbContext.BankCards.ToList();
        List<BankCardsTabRecord> bankCardsList = new List<BankCardsTabRecord>();

        foreach (var card in allBankCards)
        {
            Passport passport = card.User.Passport;
            bankCardsList.Add(new BankCardsTabRecord()
            {
                Bank = card.Bank.Title,
                Number = card.Number,
                Owner = card.Owner,
                ExpiredDate = card.ExpiredDate,
                PaymentSystem = card.PaymentSystem.Title
            });
        }

        BankCardsList = bankCardsList;
    }
}