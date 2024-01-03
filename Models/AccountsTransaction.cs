using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Транзакции и аккаунты, к которым они привязаны
/// </summary>
public partial class AccountsTransaction
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public int TransactionId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
