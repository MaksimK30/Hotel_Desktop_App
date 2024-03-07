using System.Text.RegularExpressions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class RoomsTabUC : UserControl
{
    public RoomsTabUC()
    {
        InitializeComponent();
        DataContext = new RoomsTabVM();
    }
}