using System;
using System.Reactive;
using System.Windows.Input;
using HotelDesktop.ViewModels.Tabs;
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

    public ICommand AccountCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand BankCardsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsTabVM();
        return null;
    }
    
    public ICommand BanksCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand CashDesksCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand DepartmentsCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand EmployeesCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand GuestsCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand InnsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new InnsTabVM();
        return null;
    }
    
    public ICommand MessangerCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand PassportIssuersCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand PassportsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new PassportsTabVM();
        return null;
    }

    public ICommand PaymentSystemsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand PositionsCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand ReservationsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand RoomsCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand ServicesCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand SNILSEsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new SnilsesTabVM();
        return null;
    }

    public ICommand TariffsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand TaxesCmd()
    {
        Environment.Exit(0);
        return null;
    }

    public ICommand TransactionsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand UsersCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new UsersTabVM();
        return null;
    }

    public ICommand RolePlacesSettingsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsVM();
        return null;
    }
    
    public ICommand ExitCmd()
    {
        Environment.Exit(0);
        return null;
    }
}