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
    /// <summary>
    /// Interaction logic for avvv.xaml
    /// </summary>
    public partial class avvv : Window
    {
        public struct Enter
        {
            public string login { get; set; }
            public string password { get; set; }

        }
        private string _path = "Staff.txt";
        public avvv() =>
            InitializeComponent();

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            List<string> line = File.ReadAllLines(_path).ToList();
            List<Enter> wUsers = new();
            for (int i = 0; i < line.Count - 1; i++)
            {
                string[] strings = line[i].Split("!");
                Enter user = new()
                {
                    login = strings[0],
                    password = strings[1]
                };
                if (user.login == log.Text && user.password == pass.Password)
                    DialogResult = true;
            }
        }

        private void log_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pass_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
