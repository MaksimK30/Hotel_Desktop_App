using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о бронированиях и связанных с ними гостях
/// </summary>
public partial class ReservationsGuest
{
    public int Id { get; set; }

    public int GuestId { get; set; }

    public int ReservationId { get; set; }

    public bool IsChild { get; set; }

    public virtual Guest Guest { get; set; } = null!;

    public virtual Reservation Reservation { get; set; } = null!;
}
