﻿using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о счетах пользователей
/// </summary>
public partial class Account
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int BankCardId { get; set; }

    public bool IsBlocked { get; set; }

    public string? BlockReason { get; set; }

    public virtual ICollection<AccountsTransaction> AccountsTransactions { get; set; } = new List<AccountsTransaction>();

    public virtual BankCard BankCard { get; set; } = null!;

    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual User User { get; set; } = null!;
}
