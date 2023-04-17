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
    /// Логика взаимодействия для Return.xaml
    /// </summary>
    public partial class Return : Page
    {
        public struct ReturnBookInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public int Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
            public DateTime ДатаВозврата { get; set; }
        }
        string _pathReturn = "ReturnBook.txt";
        public Return() =>
            InitializeComponent();
        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_pathReturn).ToList();
            List<ReturnBookInfo> retBook = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                retBook.Add(new()
                {
                    НомерСтудента = strings[0],
                    НомерКниги = strings[1],
                    Количество = Convert.ToInt32(strings[2]),
                    ДатаВыдачи = Convert.ToDateTime(strings[3]),
                    ДатаВозврата = Convert.ToDateTime(strings[4])
                });
            }
            Data.ItemsSource = retBook;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) =>
            Data.MinColumnWidth = Data.ActualWidth / 5;

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void Window_Closed(object? sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(_pathReturn).ToList();
            List<ReturnBookInfo> retBook = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                retBook.Add(new()
                {
                    НомерСтудента = strings[0],
                    НомерКниги = strings[1],
                    Количество = Convert.ToInt32(strings[2]),
                    ДатаВыдачи = Convert.ToDateTime(strings[3]),
                    ДатаВозврата = Convert.ToDateTime(strings[4])
                });
            }
            Data.ItemsSource = retBook;
            Search.Text = string.Empty;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddReturn window = new AddReturn();
            window.Closed += Window_Closed;
            window.Show();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
