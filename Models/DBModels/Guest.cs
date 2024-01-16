using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о гостях
/// </summary>
public partial class Guest
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int AccountId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<ReservationsGuest> ReservationsGuests { get; set; } = new List<ReservationsGuest>();

    public virtual User User { get; set; } = null!;
}
