using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DynamicData;
using HotelDesktop.Context;
using HotelDesktop.Models;
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

    public InnsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Inn> rawInnsList = new List<Inn>();
        rawInnsList = dbContext.Inns.ToList();
        List<InnTabRecord> recList = new List<InnTabRecord>();
        
        foreach (var item in rawInnsList)
        {
            Passport passport = dbContext.Passports
                .Where(p => p.Id == dbContext.Users.Where(u => u.Inn.Id == item.Id).FirstOrDefault().PassportId)
                .FirstOrDefault();
            
            recList.Add(new InnTabRecord()
            {
                Number = item.Number,
                GetDate = item.GetDate.ToString(),
                User = $"{passport.Lastname} {passport.Name[0]}.{passport.Patronymic[0]}"
            });
        }

        InnsList = new ObservableCollection<InnTabRecord>(recList);
    }
}