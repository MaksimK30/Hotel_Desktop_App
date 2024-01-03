using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Определения полов пользователей
/// </summary>
public partial class Gender
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Passport> Passports { get; set; } = new List<Passport>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
