using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Записи о документах ИНН пользователей
/// </summary>
public partial class Inn
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public DateOnly GetDate { get; set; }

    public string Lastname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
