using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class TaxesTabVM : ViewModelBase
{
    private List<TaxesTabRecord> _taxesList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public List<TaxesTabRecord> TaxesList
    {
        get { return _taxesList; }
        set { this.RaiseAndSetIfChanged(ref _taxesList, value); }
    }

    public TaxesTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Taxes> allTaxes = dbContext.Taxes.ToList();
        List<TaxesTabRecord> taxesList = new List<TaxesTabRecord>();

        foreach (var tax in allTaxes)
        {
            taxesList.Add(new TaxesTabRecord()
            {
                Description = tax.Description,
                Rate = tax.Rate,
                Title = tax.Title
            });
        }

        TaxesList = taxesList;
    }
}