using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Ифнормация об услугах отеля
/// </summary>
public partial class Service
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Cost { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
