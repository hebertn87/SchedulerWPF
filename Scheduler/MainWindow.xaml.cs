using System.Windows;
using Scheduler.Shared.ViewModel;

namespace Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ToDoListVM();
        }
    }
}