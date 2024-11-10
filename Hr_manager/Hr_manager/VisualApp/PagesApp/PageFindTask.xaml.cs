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
    /// Логика взаимодействия для PageFindTask.xaml
    /// </summary>
    public partial class PageFindTask : Page
    {
        public PageFindTask()
        {
            InitializeComponent();
            ListIntern.ItemsSource = App.Connection.Intern.ToList();
            ListTask.ItemsSource = App.Connection.Task.ToList();
        }

        private void ClEventCreate(object sender, RoutedEventArgs e)
        {

        }
    }
}
