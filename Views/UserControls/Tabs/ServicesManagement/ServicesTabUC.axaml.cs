using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class ServicesTabUC : UserControl
{
    public ServicesTabUC()
    {
        InitializeComponent();
        DataContext = new ServicesTabVM();
    }
}