using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class UsersTabVM : ViewModelBase
{
    private ObservableCollection<UsersTabRecord> _usersList;
    private ObservableCollection<String> _searchParameters;
    private int _selectedSearchParameter;

    public ObservableCollection<UsersTabRecord> UsersList
    {
        get { return _usersList; }
        set { this.RaiseAndSetIfChanged(ref _usersList, value); }
    }

    public ObservableCollection<String> SearchParameters
    {
        get { return _searchParameters; }
        set { this.RaiseAndSetIfChanged(ref _searchParameters, value); }
    }

    public int SelectedSearchParameter
    {
        get { return _selectedSearchParameter; }
        set { this.RaiseAndSetIfChanged(ref _selectedSearchParameter, value); }
    }

    public UsersTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<User> allUsers = dbContext.Users.ToList();
        UsersList = new ObservableCollection<UsersTabRecord>();
        foreach (var user in allUsers)
        {
           UsersList.Add(dbContext.Users
                .Join(dbContext.Positions, user => user.Position, position => position.Id, (user, position) => new { user, position })
                .Join(dbContext.Inns, user_pos => user_pos.user.InnId, inn => inn.Id, (user_pos, inn) => new { user_pos.user, user_pos.position, inn })
                .Join(dbContext.Passports, user_inn => user_inn.user.PassportId, passport => passport.Id, (user_inn, passport) => new { user_inn.user, user_inn.position, user_inn.inn, passport })
                .Join(dbContext.Snilses, user_pass => user_pass.user.SnilsId, snils => snils.Id, (user_pass, snils) => new UsersTabRecord
                {
                    Email = user_pass.user.Email,
                    Position = user_pass.position.Title,
                    Login = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(user_pass.user.Login)),
                    Phone = user_pass.user.Phone,
                    InnNumber = user_pass.inn.Number,
                    PassportNumber = user_pass.passport.Series + " " + user_pass.passport.Number,
                    SnilsNumber = snils.Number 
                }).First()
           );
        }
    }
}