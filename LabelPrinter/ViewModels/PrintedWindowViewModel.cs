namespace LabelPrinter.ViewModels
{
    using Models;
    public class PrintedWindowViewModel
    {
        ThermostatLabelData LabelData { get; }
        public PrintedWindowViewModel(ThermostatLabelData labelData, PrintedWindow window)
        {
            LabelData = labelData;
            window.DataContext = LabelData;
            window.InitializeComponent();
        }
    }
}