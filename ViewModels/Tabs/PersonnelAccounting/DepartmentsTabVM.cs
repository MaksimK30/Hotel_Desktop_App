using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class DepartmentsTabVM : ViewModelBase
{
    private ObservableCollection<DepartmentsTabRecord> _departmentsList;

    public ObservableCollection<DepartmentsTabRecord> DepartmentsList
    {
        get
        {
            return _departmentsList;
        }
        set { this.RaiseAndSetIfChanged(ref _departmentsList, value); }
    }

    public DepartmentsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Department> allDepartments = dbContext.Departments.ToList();
        List<DepartmentsTabRecord> recList = new List<DepartmentsTabRecord>();

        foreach (var department in allDepartments)
        {
            recList.Add(new DepartmentsTabRecord()
            {
                Title = department.Title
            });
        }

        DepartmentsList = new ObservableCollection<DepartmentsTabRecord>(recList);
    }
}