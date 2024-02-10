using Shershunov_Practika2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Shershunov_Practika2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ShershunovPractika2_kinoteatrEntities DB = new ShershunovPractika2_kinoteatrEntities();
        public static User LoggedUser;

    }
}
