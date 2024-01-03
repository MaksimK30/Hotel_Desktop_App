using ReactiveUI;

namespace HotelDesktop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    
    /////////Свойства
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private static MainWindowViewModel Instance;
    private MenuVM _currentMenu;
    private ViewModelBase _currentVM;
    private bool _menuVisible;

    public MenuVM CurrentMenu
    {
        get { return _currentMenu; }
        set
        {
            _currentMenu = value;
            this.RaisePropertyChanged();
        }
    }

    public ViewModelBase CurrentVM
    {
        get { return _currentVM; }
        set
        {
            _currentVM = value;
            this.RaisePropertyChanged();
        }
    }

    public bool MenuVisible
    {
        get { return _menuVisible; }
        set
        {
            _menuVisible = value;
            this.RaisePropertyChanged();
        }
    }
    
    /////////Функции
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public static MainWindowViewModel GetInstance()
    {
        if (Instance == null)
        {
            Instance = new MainWindowViewModel();
        }

        return Instance;
    }
    
    /////////Конструкторы
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private MainWindowViewModel()
    {
        CurrentMenu = MenuVM.GetInstance();
        MenuVisible = true;
    }
    
}