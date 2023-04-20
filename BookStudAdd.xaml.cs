using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ll
{
    /// <summary>
    /// Логика взаимодействия для BookStudAdd.xaml
    /// </summary>
    public partial class BookStudAdd : Window
    {
        public struct BookStudInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public string Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
            public override string ToString()
            {
                return $"{НомерСтудента}!{НомерКниги}!{Количество}!{ДатаВыдачи}\n";
            }
        }
        public struct StudentInfo
        {
            public int Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
        }
        public struct BookInfo
        {
            public string Автор { get; set; }
            public string Название { get; set; }
            public string Жанр { get; set; }
            public string Номер { get; set; }
            public string Издание { get; set; }
            public string Страницы { get; set; }
        }

        private readonly string _pathStudent = "Students.txt";
        private string _pathCatalog = "Catalog.txt";
        private string _pathPurchases = "BookStud.txt";
        string wSurname;
        string wName;
        string wGroup;
        BookStudInfo BSnew = new();
        public BookStudAdd() =>
            InitializeComponent();
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            DragMove();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines1 = File.ReadAllLines(_pathStudent).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines1.Count; i++)
            {
                string[] strings = lines1[i].Split(".");
                students.Add(new()
                {
                    Id = Convert.ToInt32(strings[0]),
                    Surname = strings[1].ToLower(),
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                });
                if (wSurname == students[i].Surname.ToLower() &&
                    wName == students[i].Name.ToLower() &&
                    wGroup == students[i].Group.ToLower())
                    BSnew.НомерСтудента = Convert.ToString(students[i].Id);
            }
            BSnew.ДатаВыдачи = DateTime.Now;
            if(BSnew.НомерСтудента != null &&
                BSnew.НомерКниги != null &&
                BSnew.Количество != null) File.AppendAllText(_pathPurchases, BSnew.ToString());

            Close();
        }

        private void Search_TextChanged1(object sender, TextChangedEventArgs e) =>
            wSurname = surname.Text.ToLower();

        private void Search_TextChanged2(object sender, TextChangedEventArgs e) =>
            wName = name.Text.ToLower();

        private void Search_TextChanged3(object sender, TextChangedEventArgs e) =>
            wGroup = group.Text.ToLower();

        private void Search_TextChanged4(object sender, TextChangedEventArgs e)
        {
            List<string> lines2 = File.ReadAllLines(_pathCatalog).ToList();
            List<BookInfo> books = new();

            for (int i = 0; i < lines2.Count; i++)
            {
                string[] strings = lines2[i].Split(".");
                books.Add(new()
                {
                    Автор = strings[0],
                    Название = strings[1],
                    Жанр = strings[2],
                    Номер = strings[3],
                    Издание = strings[4],
                    Страницы = strings[5]
                });
                if (books[i].Название.ToLower().Contains(IdBook.Text.ToLower()))
                    BSnew.НомерКниги = books[i].Номер;
            }
        }

        private void Search_TextChanged5(object sender, TextChangedEventArgs e)
        {
            BSnew.Количество = count.Text.ToLower();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
