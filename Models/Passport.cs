using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

public partial class Passport
{
    public int Id { get; set; }

    public DateOnly IssueDate { get; set; }

    public int IssuerId { get; set; }

    public string Series { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public int GenderId { get; set; }

    public DateOnly Birthday { get; set; }

    public string Birthlocation { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public int? PreviousPassportId { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<Passport> InversePreviousPassport { get; set; } = new List<Passport>();

    public virtual PassportIssuer Issuer { get; set; } = null!;

    public virtual Passport? PreviousPassport { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
