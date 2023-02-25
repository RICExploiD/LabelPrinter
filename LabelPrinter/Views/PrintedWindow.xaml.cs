using System;
using System.Windows;
using System.Windows.Controls;

namespace LabelPrinter
{
    using Models;
    using ViewModels;
    public partial class PrintedWindow : Window
    {
        public PrintedWindow(ThermostatLabelData labelData)
        {
            new PrintedWindowViewModel(labelData, this);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            try
            {
                var pd = new PrintDialog();
                if (pd.ShowDialog() == true)
                    pd.PrintVisual(PrintedLabel, "Label Printing Application");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }

            this.Close();
        }
    }
}
