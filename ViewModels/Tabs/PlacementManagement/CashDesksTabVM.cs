using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class CashDesksTabVM : ViewModelBase
{
    private List<CashDesksTabRecord> _cashDasksList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public List<CashDesksTabRecord> CashDesksList
    {
        get { return _cashDasksList; }
        set { this.RaiseAndSetIfChanged(ref _cashDasksList, value); }
    }

    public CashDesksTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<CashDesk> allCashDesks = dbContext.CashDesks.ToList();
        List<CashDesksTabRecord> cashDesksList = new List<CashDesksTabRecord>();

        foreach (var cashDesk in allCashDesks)
        {
            cashDesksList.Add(new CashDesksTabRecord()
            {
               Number = cashDesk.Number
            });
        }

        CashDesksList = cashDesksList;
    }
}