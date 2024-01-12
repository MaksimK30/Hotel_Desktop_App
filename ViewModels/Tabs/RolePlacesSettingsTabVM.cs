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
        RolePlacesList = new ObservableCollection<RolePlacesSettingsTabRecord>();
        List<RolePlace> allRolePlaces = dbContext.RolePlaces.ToList();
        foreach (var rp in allRolePlaces)
        {
            RolePlacesList.Add(new RolePlacesSettingsTabRecord()
            {
                Title = rp.Title
            });
        }
    }
}