using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class ReservationsTabVM : ViewModelBase
{
    private ObservableCollection<ReservationsTabRecord> _reservationsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public ObservableCollection<ReservationsTabRecord> ReservationsList
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

    public ReservationsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Reservation> allReservations = dbContext.Reservations.ToList();
        List<ReservationsTabRecord> reservaionList = new List<ReservationsTabRecord>();

        foreach (var reservation in allReservations)
        {
            
            Passport passport = reservation.MainGuest.User.Passport;
            reservaionList.Add(new ReservationsTabRecord()
            {
                Id = reservation.Id,
                ContactPhone = reservation.ContactPhone,
                StartDate = reservation.StartDate.ToString(),
                MainGuestLogin = reservation.MainGuest.User.Login,
                EndDate = reservation.EndDate.ToString(),
                LastName = passport.Lastname,
                Name = passport.Name,
                Patronymic = passport.Patronymic
            });
        }

        ReservationsList = new ObservableCollection<ReservationsTabRecord>(reservaionList);

        SearchParameters = new List<string>()
        {
            "Контактное лицо",
            "Телефон"
        };

        SelectedSearchParameter = 0;
    }
}