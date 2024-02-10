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
using Shershunov_Practika2.Models;

namespace Shershunov_Practika2.Pages
{
    /// <summary>
    /// Логика взаимодействия для GenrePage.xaml
    /// </summary>
    public partial class GenrePage : Page
    {
        public GenrePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGJanor.ItemsSource = App.DB.Janor.ToList();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddJanorPage(new Models.Janor()));
        }

        private void BRedact_Click(object sender, RoutedEventArgs e)
        {
            var selectedJanor = DGJanor.SelectedItem as Janor;
            if (selectedJanor == null)
            {
                MessageBox.Show("Неправильно");
                return;
            }
            NavigationService.Navigate(new AddJanorPage(selectedJanor));
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
