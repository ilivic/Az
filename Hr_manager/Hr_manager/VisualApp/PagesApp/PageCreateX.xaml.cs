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
    /// Логика взаимодействия для PageCreateX.xaml
    /// </summary>
    public partial class PageCreateX : Page
    {
        public static List<InternTask> _IT {  get; set; }
        public PageCreateX()
        {
            InitializeComponent();
            CMBIntern.ItemsSource = App.Connection.Intern.Where(z=>z.IsActive==true).ToList();
        }

        private void CreateXReport(object sender, RoutedEventArgs e)
        {
            var _selIntern = CMBIntern.SelectedItem as Intern;
            if (_selIntern != null) 
            {
                _IT = new List<InternTask> (App.Connection.InternTask.Where(z => z.Intern_id == _selIntern.Id_intern).ToList());
                DGT.ItemsSource = _IT;
                var _complit = _IT.Where(z => z.Task.Status_id == 3).ToList().Count;
                var _Nocomplit = _IT.Where(z => z.Task.Status_id == 2 || z.Task.Status_id == 4).ToList().Count;
                var _All = _IT.ToList().Count;
                TxtCount.Text = $"Стажер {_selIntern.FullName} \nна данный момент имеет {_All} \nиз которых выполненно {_complit} \nне выполненно {_Nocomplit}";
                var Answer = "";
                if (_complit > _Nocomplit)
                {
                    Answer = "отлично";
                }
                else if (_complit == _Nocomplit)
                { 
                    Answer = "удовлетворительно";
                }
                else
                {
                    Answer = "плохо";
                }
                var result = 100/(_All / _complit);
                TxtStatistick.Text = $"На данный момент деятельность стажера оценивается как {Answer} поскольку он выполняет {result}% заявок ";
            }
        }

        private void ClEventCreateSelImport(object sender, RoutedEventArgs e)
        {
            var _selIntern = CMBIntern.SelectedItem as Intern;
            if (_selIntern != null)
            {

            }
        }
    }
}
