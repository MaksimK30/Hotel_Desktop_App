using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class PassportsTabVM : ViewModelBase
{
    private ObservableCollection<PassportsTabRecord> _passportsList;
    private List<string> _searchParameters;
    private int _selectedSearchParameter;

    public ObservableCollection<PassportsTabRecord> PassportsList
    {
        get { return _passportsList; }
        set { this.RaiseAndSetIfChanged(ref _passportsList, value); }
    }

    public List<string> SearchParameters
    {
        get { return _searchParameters; }
        set { this.RaiseAndSetIfChanged(ref _searchParameters, value); }
    }
    
    public int SelectedSearchParameter
    {
        get { return _selectedSearchParameter; }
        set { this.RaiseAndSetIfChanged(ref _selectedSearchParameter, value); }
    }

    public PassportsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        PassportsList = new ObservableCollection<PassportsTabRecord>();
        List<Passport> allPassports = dbContext.Passports.ToList();

        foreach (var passport in allPassports)
        {
            PassportsList.Add(new PassportsTabRecord()
            {
                Series = passport.Series,
                Number = passport.Number,
                Lastname = passport.Lastname,
                Name = passport.Name,
                Patronymic = passport.Patronymic
            });
        }
        SearchParameters = new List<string>()
        {
            "Серия",
            "Номер",
            "Фамилия",
            "Имя",
            "Отчество"
        };
        SelectedSearchParameter = 0;
    }
}