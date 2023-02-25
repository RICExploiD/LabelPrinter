using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace LabelPrinter.Services
{
    public static class QrCodeCreator
    {
        public static BitmapSource CreateBitmapSource(string barcode) =>
                Imaging.CreateBitmapSourceFromHBitmap(
                    GenerateQRCode(barcode), 
                    IntPtr.Zero, Int32Rect.Empty, 
                    BitmapSizeOptions.FromEmptyOptions());
        private static IntPtr GenerateQRCode(string barcode) => 
            new MessagingToolkit.QRCode.Codec.QRCodeEncoder()
            .Encode(barcode)
            .GetHbitmap();
    }
}
