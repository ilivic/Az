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
    /// Логика взаимодействия для PageFindTask.xaml
    /// </summary>
    public partial class PageFindTask : Page
    {
        public PageFindTask()
        {
            InitializeComponent();
            ListIntern.ItemsSource = App.Connection.Intern.Where(z=>z.IsActive==true).ToList();
            ListTask.ItemsSource = App.Connection.Task.Where(z=>z.Status_id == 1||z.Status_id == 4).ToList();
            
        }

        private void ClEventCreate(object sender, RoutedEventArgs e)
        {
            if (ListIntern.SelectedItem != null && ListTask.SelectedItem != null && DPB.Text != "" && DPE.Text != "")
            {
                try
                {
                    var _task = ListTask.SelectedItem as ADOApp.Task;
                    _task.Status_id = 2;
                    var _intern = ListIntern.SelectedItem as Intern;
                    App.Connection.InternTask.Add(new ADOApp.InternTask()
                    {
                        Task = _task,
                        Intern = _intern,
                        Data = DateTime.Now,
                        DateBegin = DPB.SelectedDate.Value.Date,
                        DateEnd = DPE.SelectedDate.Value.Date,
                    });
                    App.Connection.SaveChanges();
                    MessageBox.Show("Задача привязанна к стажёру и поставлены сроки выполнения");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }
    }
}
