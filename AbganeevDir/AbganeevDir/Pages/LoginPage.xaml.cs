﻿using System;
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
using AbganeevDir.Pages;
using AbganeevDir.Models;

namespace AbganeevDir.Pages
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
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == TBPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            App.LoggedUser = user;
            NavigationService.Navigate(new MainWindowPage());
        }

        private void BRegistr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage(new User()));
        }
    }
}
