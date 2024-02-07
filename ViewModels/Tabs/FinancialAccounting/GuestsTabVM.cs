using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class GuestsTabVM : ViewModelBase
{
    private ObservableCollection<GuestsTabRecord> _reservationsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public ObservableCollection<GuestsTabRecord> ReservationsList
    {
        get { return _reservationsList; }
        set { this.RaiseAndSetIfChanged(ref _reservationsList, value); }
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

    public GuestsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Guest> allGuests = dbContext.Guests.ToList();
        List<GuestsTabRecord> guestsList = new List<GuestsTabRecord>();

        foreach (var guest in allGuests)
        {
            Passport passport = guest.User.Passport;
            guestsList.Add(new GuestsTabRecord()
            {
                Name = passport.Name,
                LastName = passport.Lastname,
                Patronymic = passport.Patronymic,
                UserLogin = guest.User.Login,
                AccountID = guest.AccountId.ToString()
            });
        }

        ReservationsList = new ObservableCollection<GuestsTabRecord>(guestsList);

        SearchParameters = new List<string>()
        {
            "ФИО",
            "Логин",
            "ID аккаунта"
        };

        SelectedSearchParameter = 0;
    }
}