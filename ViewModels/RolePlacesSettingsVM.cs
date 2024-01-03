using System.Collections.ObjectModel;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels;

public class RolePlacesSettingsVM : ViewModelBase
{
    private ObservableCollection<RolePlacesSettingsItem> _rolePlaceItemsList;
    public ObservableCollection<RolePlacesSettingsItem> RolePlaceItemsList
    {
        get { return _rolePlaceItemsList;}
        set
        {
            _rolePlaceItemsList = value;
            this.RaisePropertyChanged();
        } 
    }
    
    
    
}