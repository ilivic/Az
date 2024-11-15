﻿using System;
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
        public PageCreateX()
        {
            InitializeComponent();
            CMBIntern.ItemsSource = App.Connection.Intern.Where(z=>z.IsActive==true).ToList();
        }
    }
}
