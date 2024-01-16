using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Опиасния ролевых мест пользователей
/// </summary>
public partial class RolePlace
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public byte[]? Image { get; set; }

    public virtual ICollection<RolePlacesPosition> RolePlacesPositions { get; set; } = new List<RolePlacesPosition>();
}
