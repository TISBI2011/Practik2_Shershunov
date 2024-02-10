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
    /// Логика взаимодействия для FilmPage.xaml
    /// </summary>
    public partial class FilmPage : Page
    {
        public FilmPage()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        { 
        var filtreid = App.DB.Movies.ToList();
            var selectedDateFrom = DPDate.SelectedDate;
            var selectedDateTo = DPDateTO.SelectedDate;
            if (selectedDateTo != null)
                filtreid = filtreid.Where(x => x.DatePokaza>= selectedDateFrom).ToList();
            if (selectedDateFrom != null) 
                filtreid = filtreid.Where(x => x.DatePokaza <= selectedDateTo).ToList();
            DGFilm.ItemsSource = filtreid.ToList();
        }
        private void Badd_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new AddFilmPage(new Models.Movies() { DatePokaza = DateTime.Now}));         
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BRedact_Click(object sender, RoutedEventArgs e)
        {
            var selectedFilm = DGFilm.SelectedItem as Movies;
            if (selectedFilm == null)
            {
                MessageBox.Show("Неправильно");
                return;
            }
            NavigationService.Navigate(new AddFilmPage(selectedFilm));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGFilm.ItemsSource = App.DB.Movies.ToList();
        }

        private void TBPushCart_TextChanged(object sender, TextChangedEventArgs e)
        {

        }     

        private void TBJanorFilm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DPDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DPDateTO_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
