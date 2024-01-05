using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels;

namespace HotelDesktop.Views.UserControls;

public partial class MenuUC : UserControl
{
    public MenuUC()
    {
        InitializeComponent();
        DataContext = MenuVM.GetInstance();
    }
}