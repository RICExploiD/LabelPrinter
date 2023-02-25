#nullable disable
namespace LabelPrinter.Models
{
    using ViewModels.Base;
    public class PrintCommand : BaseCommand
    {
        public override bool CanExecute(object parameter = null) => parameter as ThermostatLabelData is not null;
        public override void Execute(object parameter = null) => new PrintedWindow(parameter as ThermostatLabelData).Show();
    }
}
