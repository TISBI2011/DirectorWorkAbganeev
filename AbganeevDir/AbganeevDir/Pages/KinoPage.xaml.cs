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

namespace AbganeevDir.Pages
{
    /// <summary>
    /// Логика взаимодействия для KinoPage.xaml
    /// </summary>
    public partial class KinoPage : Page
    {
        public KinoPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGKino.ItemsSource = App.DB.Film.ToList();
        }
    }
}
