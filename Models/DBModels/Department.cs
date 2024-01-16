using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Подразделения предприятия
/// </summary>
public partial class Department
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
