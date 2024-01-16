using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class PassportIssuersTabVM : ViewModelBase
{
    private ObservableCollection<PassportIssuersTabRec> _issuersList;

    public ObservableCollection<PassportIssuersTabRec> IssuersList
    {
        get { return _issuersList; }
        set { this.RaiseAndSetIfChanged(ref _issuersList, value); }
    }

    public PassportIssuersTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<PassportIssuer> allIssuers = dbContext.PassportIssuers.ToList();
        List<PassportIssuersTabRec> recList = new List<PassportIssuersTabRec>();
        
        foreach (var issuer in allIssuers)
        {
            recList.Add(new PassportIssuersTabRec()
            {
                Title = issuer.Title
            });
        }

        IssuersList = new ObservableCollection<PassportIssuersTabRec>(recList);
    }
}