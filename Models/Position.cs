using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

/// <summary>
/// Должности
/// </summary>
public partial class Position
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<RolePlacesPosition> RolePlacesPositions { get; set; } = new List<RolePlacesPosition>();

    public virtual User? User { get; set; }
}
