using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Сообщения пользователей
/// </summary>
public partial class Message
{
    public int Id { get; set; }

    public DateTime SendDate { get; set; }

    public int From { get; set; }

    public int To { get; set; }

    public bool IsReaded { get; set; }

    public string Theme { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public virtual User FromNavigation { get; set; } = null!;

    public virtual User ToNavigation { get; set; } = null!;
}
