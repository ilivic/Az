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
    /// Логика взаимодействия для PageAddTask.xaml
    /// </summary>
    public partial class PageAddTask : Page
    {
        public PageAddTask()
        {
            InitializeComponent();
            CmbLocation.ItemsSource = App.Connection.Location.ToList();
        }

        private void ClEventAddTask(object sender, RoutedEventArgs e)
        {
            if (TxtContent.Text != "" && TxtTitle.Text != "" && CmbLocation.SelectedItem != null)
            {
                try
                {
                    var _sel = (CmbLocation.SelectedItem as Location);
                    var _task = new ADOApp.Task()
                    {
                        Title = TxtTitle.Text,
                        TContent = TxtContent.Text,
                        Status_id = 1,
                        Location = _sel,
                        Creater_id = ClassCorr.CorrUser.Id_worker,
                    };
                    App.Connection.Task.Add(_task); 
                    App.Connection.SaveChanges();
                    MessageBox.Show("задание созданно");
                    App.Connection.Histr.Add(new Histr()
                    {
                        Task = _task,
                        date = DateTime.Now,
                        status_id = 1,
                        Title = TxtTitle.Text,
                    });
                    App.Connection.SaveChanges();
                    NavigationService.Navigate(new PageListTask());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("что-то пошло не так, повторите попытку позднее");

                }
            }
            else
            {
                    MessageBox.Show("Не все необходимые поля заполнены");
            }
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }
    }
}
