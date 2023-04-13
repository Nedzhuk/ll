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
using System.Windows.Shapes;

namespace ll
{
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
            DragMove();

        private void Search_TextChanged1(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged2(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged3(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged4(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_TextChanged5(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) =>
            Close();
    }
}