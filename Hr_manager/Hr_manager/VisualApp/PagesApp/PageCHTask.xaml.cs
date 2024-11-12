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
    /// Логика взаимодействия для PageCHTask.xaml
    /// </summary>
    public partial class PageCHTask : Page
    {
        public static ADOApp.Task _sel {  get; set; }
        public PageCHTask(ADOApp.Task _selTask)
        {
            InitializeComponent();
            _sel = _selTask;
            this.DataContext = _selTask;
            ListComments.ItemsSource = App.Connection.Comment.Where(z=>z.Task_id==_sel.Id_task).ToList();
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }

        private void CLEventShowComment(object sender, RoutedEventArgs e)
        {
            if (StackComment.Visibility == Visibility)
            {
                StackComment.Visibility = Visibility.Hidden;
            }
            else
            {
                StackComment.Visibility = Visibility.Visible;
            }
        }

        private void ClEventSendCooment(object sender, RoutedEventArgs e)
        {
            if (TxtComment.Text != "")
            {
                App.Connection.Comment.Add(new Comment()
                {
                    Creater_id = ClassApp.ClassCorr.CorrUser.Id_worker,
                    Text = TxtComment.Text,
                    DateCreate = DateTime.Now,
                    Task_id = _sel.Id_task
                });
                App.Connection.SaveChanges();
                NavigationService.Navigate(new PageCHTask(_sel));
            }
        }
    }
}
