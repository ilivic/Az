﻿#pragma checksum "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5824C59356B42B1A051754631411CEF29FD188442660973423D02EC18110672"
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
    /// PageListTask
    /// </summary>
    public partial class PageListTask : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTaskCreate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTaskAdd;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTaskRedi;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTaskError;
        
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
            System.Uri resourceLocater = new System.Uri("/Hr_manager;component/visualapp/pagesapp/pagelisttask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
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
            
            #line 22 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CLEventRevers);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListTaskCreate = ((System.Windows.Controls.ListView)(target));
            
            #line 25 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            this.ListTaskCreate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTaskCreate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListTaskAdd = ((System.Windows.Controls.ListView)(target));
            
            #line 38 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            this.ListTaskAdd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTaskCreate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListTaskRedi = ((System.Windows.Controls.ListView)(target));
            
            #line 51 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            this.ListTaskRedi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTaskCreate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListTaskError = ((System.Windows.Controls.ListView)(target));
            
            #line 64 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            this.ListTaskError.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListTaskCreate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 70 "..\..\..\..\VisualApp\PagesApp\PageListTask.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventRezetTask);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

