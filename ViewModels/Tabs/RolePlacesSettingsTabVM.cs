using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class RolePlacesSettingsTabVM : ViewModelBase
{
    private ObservableCollection<RolePlacesSettingsTabRecord> _rolePlacesList;

    public ObservableCollection<RolePlacesSettingsTabRecord> RolePlacesList
    {
        get { return _rolePlacesList; }
        set
        {
            _rolePlacesList = value;
            this.RaisePropertyChanged();
        }
    }

    public RolePlacesSettingsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<RolePlace> allRolePlaces = dbContext.RolePlaces.ToList();
        List<RolePlacesSettingsTabRecord> recList = new List<RolePlacesSettingsTabRecord>();
        
        foreach (var rp in allRolePlaces)
        {
            recList.Add(new RolePlacesSettingsTabRecord()
            {
                Title = rp.Title
            });
        }

        RolePlacesList = new ObservableCollection<RolePlacesSettingsTabRecord>(recList);
    }
}