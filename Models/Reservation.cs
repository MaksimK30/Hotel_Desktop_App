﻿using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о бронировании
/// </summary>
public partial class Reservation
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int MainGuestId { get; set; }

    public string ContactPhone { get; set; } = null!;

    public int ContactGenderId { get; set; }

    public string ContactName { get; set; } = null!;

    public int AccountId { get; set; }

    public int Childrens { get; set; }

    public int Adults { get; set; }

    public int TariffId { get; set; }

    public decimal ServiceCount { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Gender ContactGender { get; set; } = null!;

    public virtual Guest MainGuest { get; set; } = null!;

    public virtual ICollection<ReservationsGuest> ReservationsGuests { get; set; } = new List<ReservationsGuest>();

    public virtual Tariff Tariff { get; set; } = null!;
}
