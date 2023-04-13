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
using System.Windows.Shapes;

namespace ll
{
    public partial class AddStudent : Window
    {
        public struct StudentInfo
        {
            public int Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
            public override string ToString()
            {
                return $"{Id}.{Surname}.{Name}.{Group}.{Phone}.{Adress}";
            }
        }
        private readonly string _path = "Students.txt";
        StudentInfo students = new();

        public AddStudent(int lastId)
        {
            LastId = lastId;
            InitializeComponent();
        }

        private int LastId { get; set; }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            DragMove();

        private void Search_TextChanged1(object sender, TextChangedEventArgs e)
        {
            students.Surname = surname.Text;
        }

        private void Search_TextChanged2(object sender, TextChangedEventArgs e)
        {
            students.Name = name.Text;
        }

        private void Search_TextChanged3(object sender, TextChangedEventArgs e)
        {
            students.Group = group.Text;
        }

        private void Search_TextChanged4(object sender, TextChangedEventArgs e)
        {
            students.Phone = phone.Text;
        }

        private void Search_TextChanged5(object sender, TextChangedEventArgs e)
        {
            students.Adress = adress.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.Id = LastId + 1;
            File.AppendAllText(_path, students.ToString() + "\n");
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}