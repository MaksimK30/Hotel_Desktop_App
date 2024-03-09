using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class BanksTabVM : ViewModelBase
{
    private List<BanksTabRecord> _banksList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public List<BanksTabRecord> BanksList
    {
        get { return _banksList; }
        set { this.RaiseAndSetIfChanged(ref _banksList, value); }
    }

    public BanksTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Bank> allBanks = dbContext.Banks.ToList();
        List<BanksTabRecord> banksList = new List<BanksTabRecord>();

        foreach (var bank in allBanks)
        {
            banksList.Add(new BanksTabRecord()
            {
                Bik = bank.Bik,
                Ogrn = bank.Ogrn,
                Title = bank.Title,
                RegistrationNumber = bank.RegistrationNumber
            });
        }

        BanksList = banksList;
    }
}