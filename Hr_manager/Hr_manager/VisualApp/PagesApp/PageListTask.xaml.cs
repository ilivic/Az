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
    /// Логика взаимодействия для PageListTask.xaml
    /// </summary>
    public partial class PageListTask : Page
    {
        public PageListTask()
        {
            InitializeComponent();
            ListTaskCreate.ItemsSource = App.Connection.Task.Where(z=>z.Status_id == 1).ToList();
            ListTaskAdd.ItemsSource = App.Connection.Task.Where(z=>z.Status_id == 2).ToList();
            ListTaskRedi.ItemsSource = App.Connection.Task.Where(z=>z.Status_id == 3).ToList();
            ListTaskError.ItemsSource = App.Connection.Task.Where(z=>z.Status_id == 4).ToList();
        }

        private void CLEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }

        private void ListTaskCreate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _sel = (sender as ListView).SelectedItem as ADOApp.Task;
            NavigationService.Navigate(new PageCHTask(_sel));
        }

        private void ClEventRezetTask(object sender, RoutedEventArgs e)
        {
            var _sel = (sender as Button).DataContext as ADOApp.Task;
            _sel.Status_id = 1;
            App.Connection.InternTask.Remove(_sel.InternTask.First());
            App.Connection.SaveChanges();
            MessageBox.Show("Задание переназначенно");
            NavigationService.Navigate(new PageListTask());
        }
    }
}
