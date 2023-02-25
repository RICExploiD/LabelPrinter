using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;

#nullable disable
namespace LabelPrinter.ViewModels
{
    using Views;
    using Models;
    using Services;
    public class MainWindowViewModel
    {
        public ThermostatLabelData ChoosenLabelData { get; set; }
        public List<ThermostatLabelData> DataList { get; set; } = new();
        public ICommand ButtonCommand { get; set; } = new PrintCommand();
        public MainWindowViewModel(MainWindow window)
        {
            window.DataContext = this;
            window.InitializeComponent();
            LoadMaterialsFromFile();
        }

        private void LoadMaterialsFromFile()
        {
            try
            {
                var fileData = FileReader.ReadFileToEnd("src/ThermostatsData.csv");
                DataList = CsvParser.ParseCsvString(fileData).ToList();
                ChoosenLabelData = DataList[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вероятно, не найден файл!\n Проверьте существования файла и запустите приложение снова.");
                MessageBox.Show(ex.Message);
                Application.Current.Shutdown();
            }
        }
    }
}