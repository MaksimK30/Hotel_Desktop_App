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
        MainWindowViewModel.GetInstance().CurrentVM = new AccountsTabVM();
        return null;
    }

    public ICommand BankCardsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new BankCardsTabVM();
        return null;
    }
    
    public ICommand BanksCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new BanksTabVM();
        return null;
    }

    public ICommand CashDesksCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new CashDesksTabVM();
        return null;
    }
    
    public ICommand DepartmentsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new DepartmentsTabVM();
        return null;
    }

    public ICommand EmployeesCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new EmployeesTabVM();
        return null;
    }
    
    public ICommand GuestsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new GuestsTabVM();
        return null;
    }

    public ICommand InnsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new InnsTabVM();
        return null;
    }
    
    public ICommand MessangerCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new MessengerTabVM();
        return null;
    }

    public ICommand PassportIssuersCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new PassportIssuersTabVM();
        return null;
    }
    
    public ICommand PassportsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new PassportsTabVM();
        return null;
    }

    public ICommand PaymentSystemsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new PaymentSystemsTabVM();
        return null;
    }
    
    public ICommand PositionsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new PositionsTabVM();
        return null;
    }

    public ICommand ReservationsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new ReservationsTabVM();
        return null;
    }
    
    public ICommand RoomsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RoomsTabVM();
        return null;
    }

    public ICommand ServicesCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new ServicesTabVM();
        return null;
    }
    
    public ICommand SNILSEsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new SnilsesTabVM();
        return null;
    }

    public ICommand TariffsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new TariffsTabVM();
        return null;
    }
    
    public ICommand TaxesCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new TaxesTabVM();
        return null;
    }

    public ICommand TransactionsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new TransactionsTabVM();
        return null;
    }
    
    public ICommand UsersCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new UsersTabVM();
        return null;
    }

    public ICommand RolePlacesSettingsCmd()
    {
        MainWindowViewModel.GetInstance().CurrentVM = new RolePlacesSettingsTabVM();
        return null;
    }
    
    public ICommand ExitCmd()
    {
        Environment.Exit(0);
        return null;
    }
}