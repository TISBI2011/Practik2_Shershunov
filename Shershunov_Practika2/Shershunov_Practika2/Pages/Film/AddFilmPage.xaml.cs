using Shershunov_Practika2.Models;
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

namespace Shershunov_Practika2.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddFilmPage.xaml
    /// </summary>
    public partial class AddFilmPage : Page
    {
        Movies contextFilm;
        public AddFilmPage(Movies film)
        {
            
            InitializeComponent();
            TBGenre.ItemsSource = App.DB.Janor.ToList();
            TBCart.ItemsSource = App.DB.PuskinCart.ToList();
            contextFilm = film;
            DataContext = contextFilm;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {           
            if (contextFilm.id == 0)
            {
                App.DB.Movies.Add(contextFilm);

            }
            App.DB.SaveChanges();
            NavigationService.GoBack(); // переход назад после сохранения изменений
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BClouse_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
