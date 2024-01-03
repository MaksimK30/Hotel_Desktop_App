using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Информация о том, какие ролевые места доступны различным пользователйм в зависимости от от должности
/// </summary>
public partial class RolePlacesPosition
{
    public int Id { get; set; }

    public int PositionId { get; set; }

    public int RolePlaceId { get; set; }

    public virtual Position Position { get; set; } = null!;

    public virtual RolePlace RolePlace { get; set; } = null!;
}
