using System.Collections.ObjectModel;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class InnsTabVM : ViewModelBase
{
    private ObservableCollection<InnTabRecord> _innsList;

    public ObservableCollection<InnTabRecord> InnsList
    {
        get { return _innsList; }
        set
        {
            _innsList = value;
            this.RaisePropertyChanged();
        }
    }
}