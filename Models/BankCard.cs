using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о банковских карточках пользователей
/// </summary>
public partial class BankCard
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Number { get; set; } = null!;

    public string Owner { get; set; } = null!;

    public DateOnly ExpiredDate { get; set; }

    public int PaymentSystemId { get; set; }

    public int BankId { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Bank Bank { get; set; } = null!;

    public virtual PaymentSystem PaymentSystem { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
