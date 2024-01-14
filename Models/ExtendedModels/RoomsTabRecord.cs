namespace HotelDesktop.Models.ExtendedModels;

public class RoomsTabRecord
{
    public string Number { get; set; } = null!;

    public int Floor { get; set; }

    public string RoomType { get; set; }

    public int Rooms { get; set; }

    public bool Minibar { get; set; }

    public bool Jacuzzi { get; set; }

    public decimal Cost { get; set; }

}