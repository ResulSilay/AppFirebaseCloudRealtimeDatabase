﻿#pragma checksum "..\..\..\Pages\StudentList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE7FA3B638EDFCBCB204D175370B0FFD5F9BAB28"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppFirebaseCloud.Pages;
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


namespace AppFirebaseCloud.Pages {
    
    
    /// <summary>
    /// StudentList
    /// </summary>
    public partial class StudentList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\StudentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridStudents;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\StudentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnMenuDelete;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\StudentList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnList;
        
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
            System.Uri resourceLocater = new System.Uri("/AppFirebaseCloud;component/pages/studentlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\StudentList.xaml"
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
            this.dataGridStudents = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\..\Pages\StudentList.xaml"
            this.dataGridStudents.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridStudents_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMenuDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\..\Pages\StudentList.xaml"
            this.btnMenuDelete.Click += new System.Windows.RoutedEventHandler(this.btnMenuDelete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnList = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\StudentList.xaml"
            this.btnList.Click += new System.Windows.RoutedEventHandler(this.btnList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

