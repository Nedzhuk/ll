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
    /// Логика взаимодействия для IssueRefund.xaml
    /// </summary>
    public partial class IssueRefund : Page
    {
        public struct BookStudInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public int Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
        }
        public struct ReturnBookInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public int Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
            public DateTime ДатаВозврата { get; set; }
        }
        public struct IsRet
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public int КоличествоПолучено { get; set; }
            public int КоличествоВозвращено { get; set; }
            public DateTime ДатаВозврата { get; set; }
        }
        string _pathReturn = "ReturnBook.txt";
        private string _pathPurchases = "BookStud.txt";
        IsRet result = new();
        public IssueRefund()
        {
            InitializeComponent();
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
                //if()
            }
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void log_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
