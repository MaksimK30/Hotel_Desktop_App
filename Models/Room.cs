﻿using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

public partial class Room
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public int Floor { get; set; }

    public int RoomTypeId { get; set; }

    public int Rooms { get; set; }

    public bool Minibar { get; set; }

    public bool Jacuzzi { get; set; }

    public decimal Cost { get; set; }

    public virtual RoomType RoomType { get; set; } = null!;

    public virtual ICollection<RoomsPhoto> RoomsPhotos { get; set; } = new List<RoomsPhoto>();
}
