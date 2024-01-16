using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DynamicData;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class SnilsesTabVM : ViewModelBase
{
    private ObservableCollection<SnilsesTabRecord> _snilsesList;
    private List<string> _searchParameters;
    private int _selectedSearchParameter;

    public ObservableCollection<SnilsesTabRecord> SnilsesList
    {
        get { return _snilsesList; }
        set { this.RaiseAndSetIfChanged(ref _snilsesList, value); }
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

    public SnilsesTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Snils> allSnilses = new List<Snils>();
        allSnilses = dbContext.Snilses.ToList();
        List<SnilsesTabRecord> recList = new List<SnilsesTabRecord>();
        
        foreach (var snils in allSnilses)
        {
            Passport passport = dbContext.Passports
                .Where(p => p.Id == dbContext.Users.Where(u => u.Inn.Id == snils.Id).FirstOrDefault().PassportId)
                .FirstOrDefault();
            
            recList.Add(new SnilsesTabRecord()
            {
                Number = snils.Number,
                Lastname = snils.Lastname,
                Name = snils.Name,
                Patronymic = snils.Patronymic
            });
        }
        
        SnilsesList = new ObservableCollection<SnilsesTabRecord>(recList);
        
        SearchParameters = new List<string>()
        {
            "Номер",
            "Фамилия",
            "Имя",
            "Отчество"
        };
        
        SelectedSearchParameter = 0;
    }
}