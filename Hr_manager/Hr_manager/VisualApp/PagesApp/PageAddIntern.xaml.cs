using Hr_manager.ADOApp;
using Hr_manager.ClassApp;
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
    /// Логика взаимодействия для PageAddIntern.xaml
    /// </summary>
    public partial class PageAddIntern : Page
    {
        public static byte[] _image { get; set; }
        public static Intern _selI { get; set; }
        public PageAddIntern()
        {
            InitializeComponent();
            CMBInter.ItemsSource = App.Connection.Intern.Where(z => z.IsActive == true).ToList();
        }

        private void ClEventAddStr(object sender, RoutedEventArgs e)
        {
            if (TxtFIO.Text != "" && _image != null)
            {
                App.Connection.Intern.Add(new ADOApp.Intern()
                {
                    FullName = TxtFIO.Text,
                    Photo = _image,
                    DataStart = DateTime.Now,
                    IsActive = true
                });
                App.Connection.SaveChanges();
                MessageBox.Show("Стажёр добавлен");
                NavigationService.Navigate(new PageAddIntern());
            }
        }

        private void ClEventGetPhoto(object sender, RoutedEventArgs e)
        {
            _image = ClassCorr.getPhoto();
        }

        private void CMBInter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _sel = (sender as ComboBox).SelectedItem;
            if (_sel != null)
            {
                _selI = _sel as Intern;
                SPIntr.DataContext = _selI;
            }
        }

        private void ClEventUpDateIntr(object sender, RoutedEventArgs e)
        {
            if (_selI != null)
            {
                if (DPFin.SelectedDate != null)
                {
                    _selI.IsActive = false;
                }
                if (_image != null)
                {
                    _selI.Photo = _image;

                    App.Connection.SaveChanges();
                    MessageBox.Show("Данные и фото обновленны");
                }
                else
                {
                    App.Connection.SaveChanges();
                    MessageBox.Show("Данные обновленны");
                }
                NavigationService.Navigate(new PageAddIntern());
            }
            else
            {

                MessageBox.Show("Стажер не выбран");
            }
        }

        private void CLEventDell(object sender, RoutedEventArgs e)
        {
            if (_selI != null)
            {
                _selI.DataFinish = DateTime.Now;
                _selI.IsActive = false ;
                App.Connection.SaveChanges() ;
                MessageBox.Show("Стажер уволен(посмотреть информацию о нём можно через 'статистка' и 'история')");
                NavigationService.Navigate(new PageAddIntern());
            }
            else
            {
                MessageBox.Show("Стажер не выбран");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }

        private void ClEventFinis(object sender, RoutedEventArgs e)
        {
            if (_selI != null)
            {
                
                _selI.IsActive = false;
                App.Connection.SaveChanges();
                MessageBox.Show("Стажер уволен(посмотреть информацию о нём можно через 'статистка' и 'история')");
                NavigationService.Navigate(new PageAddIntern());
            }
            else
            {
                MessageBox.Show("Стажер не выбран");
            }
        }
    } 
}
