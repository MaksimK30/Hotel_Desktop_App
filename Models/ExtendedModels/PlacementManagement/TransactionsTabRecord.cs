namespace HotelDesktop.Models.ExtendedModels;

public class TransactionsTabRecord
{
    public int Id { get; set; }

    public string Date { get; set; }

    public string Description { get; set; }

    public string Tax { get; set; }

    public string CashDesk { get; set; }

    public string Service { get; set; }

    public decimal ServiceCount { get; set; }
}