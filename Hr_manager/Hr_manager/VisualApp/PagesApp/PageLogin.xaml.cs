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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void ClEventAutho(object sender, RoutedEventArgs e)
        {
            try
            {
                var Dep = Convert.ToDouble(TxtPassword.Password);
                var code = App.Connection.Worker.Where(z=>z.CodeLogin == Dep).FirstOrDefault();
                if (code != null)
                {
                    MessageBox.Show($"Добро пожаловать \n {code.Fullname}", "Добрый день", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClassCorr.CorrUser = code;
                    NavigationService.Navigate(new PageMainMenu());
                }
                else
                {
                    MessageBox.Show("неверный код");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
