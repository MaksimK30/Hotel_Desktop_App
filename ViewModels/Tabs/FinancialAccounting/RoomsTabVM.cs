using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class RoomsTabVM : ViewModelBase
{
    private ObservableCollection<RoomsTabRecord> _roomsList;
    private int _selectedRoomType;
    private List<string> _roomTypeList;
    private bool _minibarCB;
    private bool _jacuzziCB;

    public bool MinibarCB
    {
        get { return _minibarCB; }
        set { this.RaiseAndSetIfChanged(ref _minibarCB, value); }
    }

    public bool JacuzziCB
    {
        get { return _jacuzziCB; }
        set { this.RaiseAndSetIfChanged(ref _jacuzziCB, value); }
    }

    public ObservableCollection<RoomsTabRecord> RoomsList
    {
        get { return _roomsList; }
        set { this.RaiseAndSetIfChanged(ref _roomsList, value); }
    }

    public int SelectedRoomType
    {
        get { return _selectedRoomType; }
        set { this.RaiseAndSetIfChanged(ref _selectedRoomType, value); }
    }

    public List<string> RoomTypesList
    {
        get { return _roomTypeList; }
        set { this.RaiseAndSetIfChanged(ref _roomTypeList, value); }
    }

    public RoomsTabVM()
    {
        HotelDbContext dbContext = new HotelDbContext();
        List<Room> allRooms = dbContext.Rooms.ToList();
        List<RoomsTabRecord> roomsList = new List<RoomsTabRecord>();
        RoomTypesList = new List<string>();

        foreach (var room in allRooms)
        {
            roomsList.Add(new RoomsTabRecord()
            {
                Rooms = room.Rooms,
                Cost = room.Cost,
                Floor = room.Floor,
                Jacuzzi = room.Jacuzzi,
                Minibar = room.Minibar,
                Number = room.Number,
                RoomType = room.RoomType.Title
            });
        }
        
        RoomTypesList.Add("Все типы");
        RoomTypesList.AddRange(dbContext.RoomTypes.Select(r => r.Title).ToList());
        SelectedRoomType = 0;
        
        
        RoomsList = new ObservableCollection<RoomsTabRecord>(roomsList);
    }
}