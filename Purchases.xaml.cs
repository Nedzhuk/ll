using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ll
{
    /// <summary>
    /// Логика взаимодействия для Purchases.xaml
    /// </summary>
    public partial class Purchases : Page
    {
        public struct PurchasesInfo
        {
            public string idBook { get; set; }
            public string Count { get; set; }
            public string Staff { get; set; }
            public DateTime DatePurch { get; set; }
            public int sale;
        }
        private string _path = "Purchases.txt";
        public Purchases() =>
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
                    Count = strings[1],
                    Staff = strings[2],
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
                purps.Add(new ()
                {
                    idBook = strings[0],
                    Count = strings[1],
                    Staff = strings[2],
                    DatePurch = Convert.ToDateTime(strings[3])
                });
            }

            Data.ItemsSource = purps;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) =>
            Data.MinColumnWidth = Data.ActualWidth / 4;


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddPurchases window = new AddPurchases();
            window.Closed += Window_Closed;
            window.Show();
        }
        public void Window_Closed(object? sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<PurchasesInfo> purps = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                purps.Add(new()
                {
                    idBook = strings[0],
                    Count = strings[1],
                    Staff = strings[2],
                    DatePurch = Convert.ToDateTime(strings[3])
                });
            }
            Data.ItemsSource = purps;
            Search.Text = string.Empty;
        }


        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
