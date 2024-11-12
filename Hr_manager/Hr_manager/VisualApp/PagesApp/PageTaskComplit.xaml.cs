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
    /// Логика взаимодействия для PageTaskComplit.xaml
    /// </summary>
    public partial class PageTaskComplit : Page
    {
        public static ADOApp.InternTask _selTask {  get; set; }
        public PageTaskComplit()
        {
            InitializeComponent();
            ListTask.ItemsSource = App.Connection.InternTask.Where(z=>z.Task.Status_id == 2).ToList();
        }

        private void ListTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _sel = (sender as ListView).SelectedItem as ADOApp.InternTask;
            if (_sel != null)
            {
                _selTask = _sel;
                StackPanelTask.DataContext = _selTask;
                StackPanelTask.Visibility = Visibility.Visible;
            }
        }

        private void CLEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }

        private void ClEventADDComplit(object sender, RoutedEventArgs e)
        {
            _selTask.Task.Status_id = 3;
            App.Connection.SaveChanges();
            MessageBox.Show("Задание приянто");
            NavigationService.Navigate(new PageTaskComplit());
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _selTask.Task.Status_id = 4;
            App.Connection.SaveChanges();
            MessageBox.Show("Задание не приянто");
            NavigationService.Navigate(new PageTaskComplit());
        }
    }
}
