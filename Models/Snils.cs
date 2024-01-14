using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// СНИЛСы пользователей
/// </summary>
public partial class Snils
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
