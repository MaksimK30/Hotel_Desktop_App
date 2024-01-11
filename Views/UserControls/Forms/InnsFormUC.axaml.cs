using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HotelDesktop.ViewModels.Forms;

namespace HotelDesktop.Views.UserControls.Forms;

public partial class InnsFormUC : UserControl
{
    public InnsFormUC()
    {
        InitializeComponent();
        DataContext = new InnsFormVM();
    }
}