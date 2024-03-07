using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Tabs;

namespace HotelDesktop.Views.UserControls.Tabs;

public partial class TariffsTabUC : UserControl
{
    public TariffsTabUC()
    {
        InitializeComponent();
        DataContext = new TariffsTabVM();
    }
}