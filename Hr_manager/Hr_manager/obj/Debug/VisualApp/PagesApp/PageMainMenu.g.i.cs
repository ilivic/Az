﻿#pragma checksum "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B34D6772637A5452486A4856400D893EC73239F84E6E30C5C037431DECAE4E3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hr_manager.VisualApp.PagesApp;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Hr_manager.VisualApp.PagesApp {
    
    
    /// <summary>
    /// PageMainMenu
    /// </summary>
    public partial class PageMainMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LBLCount;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar PBTask;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SkrInternProgress;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTaskShow;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MainMenu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hr_manager;component/visualapp/pagesapp/pagemainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LBLCount = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.PBTask = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 3:
            this.SkrInternProgress = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.ListTaskShow = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            
            #line 55 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventShowIntern);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventShowListTask);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CLEventAddTask);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 65 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 66 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventAddStr);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 68 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CLEventTaskComplit);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 71 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventCHTaskIntr);
            
            #line default
            #line hidden
            return;
            case 12:
            this.MainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 13:
            
            #line 89 "..\..\..\..\VisualApp\PagesApp\PageMainMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.GetPhotoAndInsert);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

