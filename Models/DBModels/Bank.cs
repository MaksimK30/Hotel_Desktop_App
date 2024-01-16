using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о банках
/// </summary>
public partial class Bank
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public string Bik { get; set; } = null!;

    public string Ogrn { get; set; } = null!;

    public virtual ICollection<BankCard> BankCards { get; set; } = new List<BankCard>();
}
