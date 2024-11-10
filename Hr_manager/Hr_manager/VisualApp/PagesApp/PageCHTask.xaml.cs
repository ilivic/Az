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
        public PageCHTask(ADOApp.Task _selTask)
        {
            InitializeComponent();
            this.DataContext = _selTask;
        }
    }
}
