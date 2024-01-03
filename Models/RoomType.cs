﻿using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о типах номеров
/// </summary>
public partial class RoomType
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
