using System.Windows;
using View.ModelView;

namespace View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Initializing main window object
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainVM();
    }
}