using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ll
{
    /// <summary>
    /// Логика взаимодействия для WriteOffs.xaml
    /// </summary>
    public partial class WriteOffs : Page
    {
        public struct PurchasesInfo
        {
            public string idBook { get; set; }
            public string Staff { get; set; }
            public string bookSale { get; set; }
            public DateTime DatePurch { get; set; }
        }
        private string _path = "Purchases.txt";

        public WriteOffs() =>
            InitializeComponent();

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> line = File.ReadAllLines(_path).ToList();
            List<PurchasesInfo> purps = new();
            for (int i = 0; i < line.Count; i++)
            {
                string[] strings = line[i].Split('!');
                PurchasesInfo purch = new()
                {
                    idBook = strings[0],
                    Staff = strings[2],
                    bookSale = strings[4],
                    DatePurch = Convert.ToDateTime(strings[3])
                };
                if (purch.Staff.ToLower().Contains(Search.Text.ToLower()))
                    purps.Add(purch);
            }
            Data.ItemsSource = purps;
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> line = File.ReadAllLines(_path).ToList();
            List<PurchasesInfo> purps = new();
            for (int i = 0; i < line.Count; i++)
            {
                string[] strings = line[i].Split("!");
                purps.Add(new()
                {
                    idBook = strings[0],
                    Staff = strings[2],
                    bookSale = strings[4],
                    DatePurch = Convert.ToDateTime(strings[3])
                });
            }
            Data.ItemsSource = purps;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) =>
            Data.MinColumnWidth = Data.ActualWidth / 4;

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
