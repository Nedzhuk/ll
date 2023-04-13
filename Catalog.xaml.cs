using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public struct BookInfo
        {
            public string Автор { get; set; }
            public string Название { get; set; }
            public string Жанр { get; set; }
            public string Номер { get; set; }
            public string Издание { get; set; }
            public string Страницы { get; set; }
        }
        public Catalog() =>
            InitializeComponent();
        private string _path = "Catalog.txt";
        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                books.Add(new()
                {
                    Автор = strings[0],
                    Название = strings[1],
                    Жанр = strings[2],
                    Номер = strings[3],
                    Издание = strings[4],
                    Страницы = strings[5]
                });
            }
            Data.ItemsSource = books;
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                BookInfo book = new ()
                {
                    Автор = strings[0],
                    Название = strings[1],
                    Жанр = strings[2],
                    Номер = strings[3],
                    Издание = strings[4],
                    Страницы = strings[5]
                };
                if (book.Название.ToLower().Contains(Search.Text.ToLower()))
                    books.Add(book);
            }
            Data.ItemsSource = books;
        }
        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) => 
            Data.MinColumnWidth = Data.ActualWidth / 6;
    }
}
