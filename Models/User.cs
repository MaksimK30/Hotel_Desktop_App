using System;
using System.Collections.Generic;

namespace HotelDesktop.Models;

public partial class User
{
    public int Id { get; set; }

    public int? PassportId { get; set; }

    public int SnilsId { get; set; }

    public int? InnId { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Position { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<BankCard> BankCards { get; set; } = new List<BankCard>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();

    public virtual Position IdNavigation { get; set; } = null!;

    public virtual Inn? Inn { get; set; }

    public virtual ICollection<Message> MessageFromNavigations { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageToNavigations { get; set; } = new List<Message>();

    public virtual Passport? Passport { get; set; }

    public virtual Snilse Snils { get; set; } = null!;

    public virtual ICollection<UserJwt> UserJwts { get; set; } = new List<UserJwt>();
}
