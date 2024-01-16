using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class InnsTabUC : UserControl
{
    public InnsTabUC()
    {
        InitializeComponent();
        DataContext = new InnsTabVM();
    }
}