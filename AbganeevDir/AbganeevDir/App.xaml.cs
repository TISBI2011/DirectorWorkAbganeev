using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AbganeevDir.Models;

namespace AbganeevDir
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<User> Users = new List<User>();
        public static NaitiKinoEntities DB = new NaitiKinoEntities();
        public static User LoggedUser;
    }
}
