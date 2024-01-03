using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Тарифы на аренду номеров
/// </summary>
public partial class Tariff
{
    public int Id { get; set; }

    public decimal Cost { get; set; }

    public bool Breakfast { get; set; }

    public bool Lunch { get; set; }

    public bool Dinner { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
