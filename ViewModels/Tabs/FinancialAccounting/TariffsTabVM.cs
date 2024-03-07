using System.Collections.Generic;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class TariffsTabVM : ViewModelBase
{
    private bool _hasBreakfast;
    private bool _hasLunch;
    private bool _hasDinner;
    private List<TariffsTabRecord> _tariffsList;
    private HotelDbContext _dbContext = new HotelDbContext();

    public bool HasBreakfast
    {
        get { return _hasBreakfast; }
        set { this.RaiseAndSetIfChanged(ref _hasBreakfast, value); }
    }
    public bool HasLunch
    {
        get { return _hasLunch; }
        set { this.RaiseAndSetIfChanged(ref _hasLunch, value); }
    }
    public bool HasDinner
    {
        get { return _hasDinner; }
        set { this.RaiseAndSetIfChanged(ref _hasDinner, value); }
    }
    public List<TariffsTabRecord> TariffsList
    {
        get { return _tariffsList; }
        set { this.RaiseAndSetIfChanged(ref _tariffsList, value); }
    }

    public TariffsTabVM()
    {
        List<TariffsTabRecord> tariffsTmpList = new List<TariffsTabRecord>();
        foreach (var tariff in _dbContext.Tariffs.ToList())
        {
            tariffsTmpList.Add(new TariffsTabRecord()
            {
                Title = tariff.Title,
                Breakfast = tariff.Breakfast,
                Lunch = tariff.Lunch,
                Dinner = tariff.Dinner,
                Cost = tariff.Cost,
            });
        }

        TariffsList = tariffsTmpList;
    }
}