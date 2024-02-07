using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelDesktop.Context;
using HotelDesktop.Models;
using HotelDesktop.Models.ExtendedModels;
using ReactiveUI;

namespace HotelDesktop.ViewModels.Tabs;

public class RoomsTabVM : ViewModelBase
{
    private ObservableCollection<RoomsTabRecord> _roomsList;
    private int _selectedSearchParameter;
    private List<string> _searchParameters;
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

    public int SelectedSearchParameter
    {
        get { return _selectedSearchParameter; }
        set { this.RaiseAndSetIfChanged(ref _selectedSearchParameter, value); }
    }

    public List<string> SearchParameters
    {
        get { return _searchParameters; }
        set { this.RaiseAndSetIfChanged(ref _searchParameters, value); }
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

        foreach (var room in allRooms)
        {
            roomsList.Add(new RoomsTabRecord()
            {

            });
        }

        RoomsList = new ObservableCollection<RoomsTabRecord>(roomsList);

        SearchParameters = new List<string>()
        {
            "Номер",
            "Этаж"
        };

        SelectedSearchParameter = 0;
    }
}