using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HabitTracker.ViewModels;

namespace HabitTracker.Views;

public partial class HabitView : UserControl
{
    public HabitView()
    {
        InitializeComponent();
        DataContext = new HabitViewModel();
    }
}