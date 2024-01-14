using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class PassportIssuersTabUC : UserControl
{
    public PassportIssuersTabUC()
    {
        InitializeComponent();
        DataContext = new PassportIssuersTabVM();
    }
}