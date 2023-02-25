namespace LabelPrinter.Models
{
    using Services;
    public class ThermostatLabelData
    {
        public System.Windows.Media.Imaging.BitmapSource QRLabel { get => QrCodeCreator.CreateBitmapSource(Barcode); }
        public string Barcode { get => $"00{Material}{System.DateTime.Now.Date:ddMMyy}"; }
        public string FormatedDate { get => $"{System.DateTime.Now.Date:dd/MM/yy}"; }
        public string Description { get; }
        public string Material { get; }
        public ThermostatLabelData(string material, string description)
        {
            Material = material;
            Description = description;
        }
    }
}