using Hr_manager.ADOApp;
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

namespace Hr_manager.VisualApp.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAddLocation.xaml
    /// </summary>
    public partial class PageAddLocation : Page
    {
        public static byte[] _image {  get; set; }
        public PageAddLocation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _image = ClassApp.ClassCorr.getPhoto();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TxtName.Text != "")
            {
                Location _loc = new Location()
                {
                    Adress = TxtAdress.Text,
                    Locc = TxtName.Text,
                    Diskription = TxtDiskroption.Text,
                    Photo = _image
                };
                App.Connection.Location.Add(_loc);
                App.Connection.SaveChanges();
                MessageBox.Show("локация добавленна успешно");
            }

        }

        private void ClEventREvers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }
    }
}
