using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class EmployeesTabVM : ViewModelBase
{
    private ObservableCollection<EmployeesTabRecord> _employeesList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public ObservableCollection<EmployeesTabRecord> EmployeesList
    {
        get { return _employeesList; }
        set { this.RaiseAndSetIfChanged(ref _employeesList, value); }
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

    public EmployeesTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Employee> allEmployees = dbContext.Employees.ToList();
        List<EmployeesTabRecord> recList = new List<EmployeesTabRecord>();

        foreach (var employee in allEmployees)
        {
             recList.Add(new EmployeesTabRecord()
            {
                Name = employee.User.Passport.Name,
                Patronymic = employee.User.Passport.Patronymic,
                LastName = employee.User.Passport.Lastname,
                Position = employee.Position.Title,
                Salary = employee.Salary.ToString(),
                FireDate = employee.FireDate.ToString(),
                HireDate = employee.HireDate.ToString(),
                IsFired = employee.IsFired,
                UserLogin = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(employee.User.Login)) 
            });
        }

        EmployeesList = new ObservableCollection<EmployeesTabRecord>(recList);

        SearchParameters = new List<string>()
        {
            "Фамилия",
            "Имя",
            "Отчество",
            "Логин",
            "Должность",
            "Зарплата от",
            "Зарплата до",
            "Зарплата"
        };

        SelectedSearchParameter = 0;
    }
}