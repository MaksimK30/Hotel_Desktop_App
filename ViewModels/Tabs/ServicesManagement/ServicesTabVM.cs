using System.Collections.Generic;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class ServicesTabVM : ViewModelBase
{
    private HotelDbContext _dbContext = new HotelDbContext();
 
    private string _minCost;
    private string _maxCost;
    private List<ServicesTabRecord> _servicesList;
    public string MinCost
    {
        get { return _minCost; }
        set { this.RaiseAndSetIfChanged(ref _minCost, value); }
    }
    public string MaxCost
    {
        get { return _maxCost; }
        set { this.RaiseAndSetIfChanged(ref _maxCost, value); }
    }
    public List<ServicesTabRecord> ServicesList
    {
        get { return _servicesList; }
        set { this.RaiseAndSetIfChanged(ref _servicesList, value); }
    }
    public ServicesTabVM()
    {
        List<ServicesTabRecord> servicesTmpList = new List<ServicesTabRecord>();
        foreach (var service in _dbContext.Services.ToList())
        {
            servicesTmpList.Add(new ServicesTabRecord()
            {
                Title = service.Title,
                Description = service.Description,
                Cost = service.Cost,
            });
        }

        ServicesList = servicesTmpList;
    }
}