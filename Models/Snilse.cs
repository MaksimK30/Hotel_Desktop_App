using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// СНИЛСы пользователей
/// </summary>
public partial class Snilse
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
