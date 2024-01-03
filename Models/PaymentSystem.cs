using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Платёжные системы
/// </summary>
public partial class PaymentSystem
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<BankCard> BankCards { get; set; } = new List<BankCard>();
}
