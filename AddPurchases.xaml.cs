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
using System.Windows.Shapes;

namespace ll
{
    /// <summary>
    /// Логика взаимодействия для AddPurchases.xaml
    /// </summary>
    public partial class AddPurchases : Window
    {
        public struct PurchasesInfo
        {
            public string idBook { get; set; }
            public string Count { get; set; }
            public string Staff { get; set; }
            public DateTime DatePurch { get; set; }
            public int bookSale;

            public override string ToString()
            {
                return $"{idBook}!{Count}!{Staff}!{DatePurch}!{bookSale}\n";
            }
        }
        public struct BookInfo
        {
            public string Название { get; set; }
            public string Номер { get; set; }
        }
        public struct Enter
        {
            public string login { get; set; }
            public string password { get; set; }

        }
        public struct BookSaleInfo
        {
            public string Автор { get; set; }
            public string Название { get; set; }
            public int Цена { get; set; }
        }
        private readonly string _pathSale = "SaleBooks.txt";
        private string _path = "Purchases.txt";
        private string _pathCatalog = "Catalog.txt";
        private string _pathStaff = "Staff.txt";

        PurchasesInfo ad = new();
        public AddPurchases() =>
            InitializeComponent();

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            DragMove();

        private void Search_TextChanged1(object sender, TextChangedEventArgs e)
        {
        }

        private void Search_TextChanged2(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged3(object sender, TextChangedEventArgs e) =>
            ad.Count = count.Text;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_pathStaff).ToList();
            List<Enter> staf = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] stringss = lines[i].Split("!");
                staf.Add(new()
                {
                    login = stringss[0],
                    password = stringss[1],
                });
                if (staf[i].login == log.Text)
                    ad.Staff = staf[i].login;
            }

            List<string> lines2 = File.ReadAllLines(_pathCatalog).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines2.Count; i++)
            {
                string[] strings = lines2[i].Split(".");
                books.Add(new()
                {
                    Название = strings[1],
                    Номер = strings[3],
                });
                if (books[i].Название.ToLower() == book.Text.ToLower())
                    ad.idBook = books[i].Номер;
            }
            ad.DatePurch = DateTime.Now;

            //тут будет цена
            List<string> linesses = File.ReadAllLines(_pathSale).ToList();

            for (int i = 0; i < linesses.Count - 1; i++)
            {
                string[] stringses = linesses[i].Split(".");
                BookSaleInfo bookSale = new()
                {
                    Автор = stringses[0],
                    Название = stringses[1],
                    Цена = Convert.ToInt32(stringses[2]),
                };
                if (book.Text.ToLower() == bookSale.Название.ToLower())
                    ad.bookSale = Convert.ToInt32(ad.Count) * bookSale.Цена;
            }

            if (ad.idBook != null &&
                ad.Staff != null)
                File.AppendAllText(_path, ad.ToString());
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) =>
            Close();
    }
}
