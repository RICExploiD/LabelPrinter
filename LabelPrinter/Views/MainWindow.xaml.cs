using System.Windows;

namespace LabelPrinter.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            new ViewModels.MainWindowViewModel(this);
        }
    }
}
