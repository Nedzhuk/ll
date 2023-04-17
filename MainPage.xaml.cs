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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ll
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Students());
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Catalog());
        }

        private void Sale_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SaleBook());
        }

        private void Purchases_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BookStud());
        }
    }
}
