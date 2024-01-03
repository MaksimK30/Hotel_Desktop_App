﻿using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о выданных токенах доступа
/// </summary>
public partial class UserJwt
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string RefreshToken { get; set; } = null!;

    public string? Device { get; set; }

    public string? Ip { get; set; }

    public string? Address { get; set; }

    public string AccessToken { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
