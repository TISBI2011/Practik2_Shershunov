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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = TBLogin.Text;
            string Password = TBPassword.Text;

            var loggedUser = App.DB.User.FirstOrDefault(x => x.Login == login && x.Password == Password);

            if(loggedUser == null)
            {
                MessageBox.Show("Введены неправильные данные проверьте логин или пароль");
                return;
            }
            NavigationService.Navigate(new MainPage());
            App.LoggedUser = loggedUser;
        }

        private void BRegistr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
