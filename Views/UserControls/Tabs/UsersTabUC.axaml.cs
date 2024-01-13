using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class UsersTabUC : UserControl
{
    public UsersTabUC()
    {
        InitializeComponent();
        DataContext = new UsersTabVM();
    }
}