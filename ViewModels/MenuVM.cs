using System;
using System.Reactive;
using System.Windows.Input;
using ReactiveUI;

namespace HotelDesktop.ViewModels;

public class MenuVM : ViewModelBase
{
    private static MenuVM instance;
    
    public static MenuVM GetInstance()
    {
        if (instance == null)
        {
            instance = new MenuVM();
        }

        return instance;
    }
    
    private MenuVM()
    {
    }

    public ICommand ExitCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand RolePlacesSettingsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
}