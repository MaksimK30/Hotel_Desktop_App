using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class PositionsTabVM : ViewModelBase
{
    private ObservableCollection<PositionsTabRecord> _positionsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public ObservableCollection<PositionsTabRecord> PositionsList
    {
        get { return _positionsList; }
        set { this.RaiseAndSetIfChanged(ref _positionsList, value); }
    }

    public int SelectedSearchParameter
    {
        get { return _selectedSearchParameter; }
        set { this.RaiseAndSetIfChanged(ref _selectedSearchParameter, value); }
    }

    public List<string> SearchParameters
    {
        get { return _searchParameters; }
        set { this.RaiseAndSetIfChanged(ref _searchParameters, value); }
    }

    public PositionsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Position> allPositions = dbContext.Positions.ToList();
        List<PositionsTabRecord> recList = new List<PositionsTabRecord>();

        foreach (var position in allPositions)
        {
             recList.Add(new PositionsTabRecord()
            {
                Title = position.Title,
                Department = position.Department.Title
            });
        }

        PositionsList = new ObservableCollection<PositionsTabRecord>(recList);

        SearchParameters = new List<string>()
        {
            "Должность",
            "Отдел"
        };

        SelectedSearchParameter = 0;
    }
}