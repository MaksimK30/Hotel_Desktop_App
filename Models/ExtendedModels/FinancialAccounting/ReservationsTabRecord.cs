namespace HotelDesktop.Models.ExtendedModels;

public class ReservationsTabRecord
{
    public int Id { get; set; }

    public string StartDate { get; set; }

    public string EndDate { get; set; }

    public string MainGuestLogin { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }

    public string ContactPhone { get; set; }
}