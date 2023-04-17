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
    /// Логика взаимодействия для BookStud.xaml
    /// </summary>
    public partial class BookStud : Page
    {
        public struct BookStudInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public int Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
        }
        //private readonly string _pathStudent = "Students.txt";
        //private string _pathCatalog = "Catalog.txt";
        private string _pathPurchases = "BookStud.txt";
        public BookStud() =>
            InitializeComponent();

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //List<string> lines = File.ReadAllLines(_pathPurchases).ToList();
            //List<BookStudInfo> students = new();

            //for (int i = 0; i < lines.Count; i++)
            //{
            //    string[] strings = lines[i].Split("!");
            //    students.Add(new()
            //    {
            //        НомерСтудента = strings[0],
            //        НомерКниги = strings[1],
            //        Количество = Convert.ToInt32(strings[2]),
            //        ДатаВыдачи = Convert.ToDateTime(strings[3])
            //    });
            //}

            BookStudAdd window = new BookStudAdd();
            window.Closed += Window_Closed;
            window.Show();
        }
        public void Window_Closed(object? sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(_pathPurchases).ToList();
            List<BookStudInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                students.Add(new()
                {
                    НомерСтудента = strings[0],
                    НомерКниги = strings[1],
                    Количество = Convert.ToInt32(strings[2]),
                    ДатаВыдачи = Convert.ToDateTime(strings[3])
                });
            }
            Data.ItemsSource=students;
            Search.Text = string.Empty;
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {

            List<string> lines = File.ReadAllLines(_pathPurchases).ToList();
            List<BookStudInfo> bbokStudInf = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                bbokStudInf.Add(new()
                {
                    НомерСтудента = strings[0],
                    НомерКниги = strings[1],
                    Количество = Convert.ToInt32(strings[2]),
                    ДатаВыдачи = Convert.ToDateTime(strings[3])
                });
            }
            Data.ItemsSource = bbokStudInf;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e) =>
            Data.MinColumnWidth = Data.ActualWidth / 4;

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_pathPurchases).ToList();
            List<BookStudInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split("!");
                BookStudInfo student = new()
                {
                    НомерСтудента = strings[0],
                    НомерКниги = strings[1],
                    Количество = Convert.ToInt32(strings[2]),
                    ДатаВыдачи = Convert.ToDateTime(strings[3])
                };
                if (student.НомерСтудента.Contains(Search.Text))
                    students.Add(student);
            }
            Data.ItemsSource = students;
        }
    }
}
