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
    /// Логика взаимодействия для PageInternList.xaml
    /// </summary>
    public partial class PageInternList : Page
    {
        public PageInternList()
        {
            InitializeComponent();
            ListIntern.ItemsSource = App.Connection.Intern.Where(z=>z.IsActive==true).ToList();
        }

        private void ListIntern_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _sel = (sender as ListView).SelectedItem as ADOApp.Intern;
            if (_sel != null) 
            {
               ListTask.ItemsSource = App.Connection.InternTask.Where(z=>z.Intern_id == _sel.Id_intern).ToList();
            }
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }
    }
}
