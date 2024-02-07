using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class ReservationsTabUC : UserControl
{
    public ReservationsTabUC()
    {
        InitializeComponent();
        DataContext = new ReservationsTabVM();
    }
}