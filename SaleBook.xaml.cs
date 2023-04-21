using System;
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
using System.IO;

namespace ll
{
    /// <summary>
    /// Логика взаимодействия для SaleBook.xaml
    /// </summary>
    public partial class SaleBook : Page
    {
        public struct BookInfo
        {
            public string Автор { get; set; }
            public string Название { get; set; }
            public int Цена { get; set; }
        }
        private readonly string _path = "SaleBooks.txt";
        public SaleBook() =>
            InitializeComponent();

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines.Count-1; i++)
            {
                string[] strings = lines[i].Split(".");
                books.Add(new()
                {
                    Автор = strings[0],
                    Название = strings[1],
                    Цена = Convert.ToInt32(strings[2]),
                });
            }
            Data.ItemsSource = books;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines.Count-1; i++)
            {
                string[] strings = lines[i].Split(".");
                BookInfo book = new()
                {
                    Автор = strings[0],
                    Название = strings[1],
                    Цена = Convert.ToInt32(strings[2]),
                };
                if (book.Название.ToLower().Contains(Search.Text.ToLower()))
                    books.Add(book);
            }
            Data.ItemsSource = books;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) =>
            Data.MinColumnWidth = Data.ActualWidth / 3;
    }
}
