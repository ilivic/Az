using Hr_manager.ClassApp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PageMainMenu.xaml
    /// </summary>
    public partial class PageMainMenu : Page
    {
        public PageMainMenu()
        {
            InitializeComponent();
            this.DataContext = ClassCorr.CorrUser;
            GetCount();
            GetInternCount();
            var _selDat = DateTime.Now.Date.Date;
            ListTaskShow.ItemsSource = App.Connection.InternTask.Where(z => z.DateEnd == _selDat).ToList();
        }
        private void GetInternCount()
        {
            var _list = App.Connection.Intern.Where(x => x.IsActive == true).ToList();
            foreach (var intern in _list)
            { 
                Label lbl = new Label();
                lbl.Content = intern.FullName;
                ProgressBar bar = new ProgressBar();
                var _litleList = App.Connection.InternTask.Where(z => z.Intern_id == intern.Id_intern).ToList();
                bar.Maximum = _litleList.Count;
                bar.Value = _litleList.Where(z=>z.Task.Status_id==3).ToList().Count;
                Label lblRez = new Label();
                lblRez.Content = $"{_litleList.Where(z => z.Task.Status_id == 3).ToList().Count}/{_litleList.Count}";
                SkrInternProgress.Children.Add(lbl);
                SkrInternProgress.Children.Add(lblRez);
                SkrInternProgress.Children.Add(bar);
            }
        }
            private void GetCount()
        {
            var _selFo = App.Connection.Task.ToList();
            var _first = _selFo.Count;
            var _Sec = _selFo.Where(z=>z.Status_id==3).ToList().Count;
            LBLCount.Content = $"{_Sec}/{_first}";
            PBTask.Maximum = _first;
            PBTask.Value = _Sec;
        }

        private void GetPhotoAndInsert(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    ClassCorr.CorrUser.Face = File.ReadAllBytes(dialog.FileName);
                    App.Connection.SaveChanges();
                    MessageBox.Show("Up Date You Face \n My Litlle Ai номрально пишем");
                } 
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ClEventAddStr(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddIntern());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddLocation());
        }

        private void CLEventAddTask(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddTask());
        }

        private void ClEventShowListTask(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageListTask());
        }

        private void ClEventCHTaskIntr(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageFindTask());

        }

        private void CLEventTaskComplit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTaskComplit());

        }

        private void ClEventShowIntern(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageInternList());

        }

        private void ClEventCreateXReport(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCreateX());

        }
    }
}
