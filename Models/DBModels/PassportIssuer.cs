using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Отделения выдачи паспортов
/// </summary>
public partial class PassportIssuer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Passport> Passports { get; set; } = new List<Passport>();
}
