using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о финансовых транзакциях
/// </summary>
public partial class Transaction
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public string Description { get; set; } = null!;

    public int TaxId { get; set; }

    public int CashDeskId { get; set; }

    public int ServiceId { get; set; }

    public decimal ServiceCount { get; set; }

    public virtual ICollection<AccountsTransaction> AccountsTransactions { get; set; } = new List<AccountsTransaction>();

    public virtual CashDesk CashDesk { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;

    public virtual Taxis Tax { get; set; } = null!;
}
