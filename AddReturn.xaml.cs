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
    /// Логика взаимодействия для AddReturn.xaml
    /// </summary>
    public partial class AddReturn : Window
    {
        public struct ReturnBookInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public string Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
            public DateTime ДатаВозврата { get; set; }
            public override string ToString()
            {
                return $"{НомерСтудента}!{НомерКниги}!{Количество}!{ДатаВыдачи}!{ДатаВозврата}\n";
            }
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
        public struct StudentInfo
        {
            public string Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
        }
        public struct BookStudInfo
        {
            public string НомерСтудента { get; set; }
            public string НомерКниги { get; set; }
            public string Количество { get; set; }
            public DateTime ДатаВыдачи { get; set; }
        }

        private string _pathBookStud = "BookStud.txt";
        private string _pathReturn = "ReturnBook.txt";
        private string _pathCatalog = "Catalog.txt";
        private string _pathStudent = "Students.txt";

        string wID;
        string wNameBook;
        string wCount;

        ReturnBookInfo retBook = new();
        public AddReturn() =>
            InitializeComponent();

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            DragMove();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines2 = File.ReadAllLines(_pathBookStud).ToList();
            List<BookStudInfo> stBook = new();

            for (int j = 0; j < lines2.Count; j++)
            {
                string[] strings1 = lines2[j].Split("!");
                stBook.Add(new()
                {
                    НомерСтудента = strings1[0],
                    НомерКниги = strings1[1],
                    Количество = strings1[2],
                    ДатаВыдачи = Convert.ToDateTime(strings1[3])
                });
                if ()
                {
                    retBook.НомерСтудента = stBook[j].НомерСтудента;
                    retBook.НомерКниги = stBook[j].НомерКниги;
                    retBook.Количество = stBook[j].Количество;
                    retBook.ДатаВыдачи = stBook[j].ДатаВыдачи;
                }
            }
            retBook.ДатаВозврата = DateTime.Now;
            if (retBook.НомерСтудента != null &&
                retBook.НомерКниги != null &&
                retBook.Количество != null)
                File.AppendAllText(_pathReturn, retBook.ToString());

            Close();
        }

        private void Search_TextChanged1(object sender, TextChangedEventArgs e)
        {

        }


        private void Search_TextChanged2(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged3(object sender, TextChangedEventArgs e)
        {
            List<string> lines1 = File.ReadAllLines(_pathStudent).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines1.Count; i++)
            {
                string[] strings = lines1[i].Split(".");
                students.Add(new()
                {
                    Id = strings[0],
                    Surname = strings[1].ToLower(),
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                });
                if (students[i].Group.ToLower() == group.Text.ToLower() &&
                    students[i].Surname.ToLower() == surname.Text.ToLower() &&
                    students[i].Name.ToLower() == name.Text.ToLower())
                    wID = students[i].Id;
            }
        }


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
                if (books[i].Название.ToLower().Contains(nameBook.Text.ToLower()))
                    wNameBook = books[i].Номер;
            }
        }

        private void Search_TextChanged5(object sender, TextChangedEventArgs e) =>
            wCount = count.Text.ToLower();

        private void Button_Click_1(object sender, RoutedEventArgs e) =>
            Close();
    }
}
