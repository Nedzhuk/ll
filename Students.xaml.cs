using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ll
{
    public partial class Students : Page
    {
        public struct StudentInfo
        {
            public int Id { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
        }
        private readonly string _path = "Students.txt";
        public Students() =>
            InitializeComponent();

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                students.Add(new()
                {
                    Id = Convert.ToInt32(strings[0]),
                    Surname = strings[1],
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                });
            }
            Data.ItemsSource = students;
        }

        private void Data_SizeChanged(object sender, SizeChangedEventArgs e)
            => Data.MinColumnWidth = Data.ActualWidth / 6;

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                StudentInfo student = new()
                {
                    Id = Convert.ToInt32(strings[0]),
                    Surname = strings[1],
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                };
                if (student.Surname.ToLower().Contains(Search.Text.ToLower()))
                    students.Add(student);
            }
            Data.ItemsSource = students;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                students.Add(new()
                {
                    Id = Convert.ToInt32(strings[0]),
                    Surname = strings[1],
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                });
            }
            
            AddStudent window = new AddStudent(students.Last().Id);
            window.Closed += Window_Closed;
            window.Show();
        }

        private void Window_Closed(object? sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();
            List<StudentInfo> students = new();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] strings = lines[i].Split(".");
                students.Add(new()
                {
                    Id = Convert.ToInt32(strings[0]),
                    Surname = strings[1],
                    Name = strings[2],
                    Group = strings[3],
                    Phone = strings[4],
                    Adress = strings[5]
                });
            }
            Data.ItemsSource = students;
            Search.Text = string.Empty;
        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
