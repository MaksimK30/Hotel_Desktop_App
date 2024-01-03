using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Записи о документах ИНН пользователей
/// </summary>
public partial class Inn
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public DateOnly? GetDate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
