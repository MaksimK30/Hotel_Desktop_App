using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class TransactionsTabVM : ViewModelBase
{
    private List<TransactionsTabRecord> _reservationsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;

    public List<TransactionsTabRecord> TransactionsList
    {
        get { return _reservationsList; }
        set { this.RaiseAndSetIfChanged(ref _reservationsList, value); }
    }

    public TransactionsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Transaction> allTransactions = dbContext.Transactions.ToList();
        List<TransactionsTabRecord> transactionsList = new List<TransactionsTabRecord>();

        foreach (var transaction in allTransactions)
        {
            transactionsList.Add(new TransactionsTabRecord()
            {
                Id = transaction.Id,
                Date = transaction.Date.ToString(),
                Description = transaction.Description,
                Service = transaction.Service.Title,
                Tax = transaction.Tax.Title,
                CashDesk = transaction.CashDesk.Number,
                ServiceCount = transaction.ServiceCount
            });
        }

        TransactionsList = transactionsList;
    }
}