using Hr_manager.ADOApp;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using _excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;


namespace Hr_manager.VisualApp.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageCreateX.xaml
    /// </summary>
    public partial class PageCreateX : Page
    {
        public static List<InternTask> _IT {  get; set; }
        public static int _complit {  get; set; }
        public static int _Nocomplit {  get; set; }
        public static int _All {  get; set; }
        public static double result {  get; set; }
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
                _complit = _IT.Where(z => z.Task.Status_id == 3).ToList().Count;
                _Nocomplit = _IT.Where(z => z.Task.Status_id == 2 || z.Task.Status_id == 4).ToList().Count;
                _All = _IT.ToList().Count;
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
                result = 100/(_All / _complit);
                TxtStatistick.Text = $"На данный момент деятельность стажера оценивается как {Answer} поскольку он выполняет {result}% заявок ";
            }
        }

        private void ClEventCreateSelImport(object sender, RoutedEventArgs e)
        {
            var _selIntern = CMBIntern.SelectedItem as Intern;
            if (_selIntern != null)
            {
                _Application excel = new _excel.Application();
                Workbook _wb;
                Worksheet _ws;
                _wb = excel.Workbooks.Add();
                _ws = _wb.Worksheets[1];
                _ws.Cells[1, 1].Value2 = "Стажер";
                _ws.Cells[1, 2].Value2 = _selIntern.FullName;
                _ws.Cells[1, 1].Value2 = "Работает с ";
                _ws.Cells[2, 2].Value2 = _selIntern.DataStart;
                _ws.Cells[3, 1].Value2 = "процент выполнения заявок";
                _ws.Cells[3, 2].Value2 = result;
                _ws.Cells[4, 1].Value2 = "Название";
                _ws.Cells[4, 2].Value2 = "Место выполнения";
                _ws.Cells[4, 3].Value2 = "Статус";
                _ws.Cells[4, 4].Value2 = "Дата начала выполнения";
                _ws.Cells[4, 5].Value2 = "Дата сдачи";
                _ws.Cells[4, 6].Value2 = "Дата выдачи задания"; 
                var i = 5;
                foreach (var index in _IT.ToList())
                {
                    _ws.Cells[i, 1].Value2 = index.Task.Title;
                    _ws.Cells[i, 2].Value2 = index.Task.Location.Locc;
                    _ws.Cells[i, 3].Value2 = index.Task.Status.Info;
                    _ws.Cells[i, 4].Value2 = index.DateBegin;
                    _ws.Cells[i, 5].Value2 = index.DateEnd;
                    _ws.Cells[i, 6].Value2 = index.Data;
                    i++;
                }
                _wb.SaveAs("ReportX.xlsx");
                _wb.Close();
            }
        }


        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainMenu());
        }
    }
}
