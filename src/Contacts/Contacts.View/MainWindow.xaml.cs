using System.Windows;
using Contacts.ViewModel;

namespace Contacts.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main Window logic.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
    }
}