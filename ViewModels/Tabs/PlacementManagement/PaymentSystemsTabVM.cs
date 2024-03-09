using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class PaymentSystemsTabVM : ViewModelBase
{
    private List<PaymentSystemsTabRecord> _paymentSystemsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public List<PaymentSystemsTabRecord> PaymentSystemsList
    {
        get { return _paymentSystemsList; }
        set { this.RaiseAndSetIfChanged(ref _paymentSystemsList, value); }
    }

    public PaymentSystemsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<PaymentSystem> allPaymentSystems = dbContext.PaymentSystems.ToList();
        List<PaymentSystemsTabRecord> paymentSystemsList = new List<PaymentSystemsTabRecord>();

        foreach (var system in allPaymentSystems)
        {
            paymentSystemsList.Add(new PaymentSystemsTabRecord()
            {
                Title = system.Title
            });
        }

        PaymentSystemsList = paymentSystemsList;
    }
}