﻿#pragma checksum "..\..\..\BookStudAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4D47C80E1A7A772D6A938B8704771765BAF0E2B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using ll;


namespace ll {
    
    
    /// <summary>
    /// BookStudAdd
    /// </summary>
    public partial class BookStudAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 186 "..\..\..\BookStudAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surname;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\BookStudAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\BookStudAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox group;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\BookStudAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdBook;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\BookStudAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox count;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ll;component/bookstudadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookStudAdd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\BookStudAdd.xaml"
            ((ll.BookStudAdd)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.surname = ((System.Windows.Controls.TextBox)(target));
            
            #line 186 "..\..\..\BookStudAdd.xaml"
            this.surname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            
            #line 187 "..\..\..\BookStudAdd.xaml"
            this.name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.group = ((System.Windows.Controls.TextBox)(target));
            
            #line 188 "..\..\..\BookStudAdd.xaml"
            this.group.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged3);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IdBook = ((System.Windows.Controls.TextBox)(target));
            
            #line 189 "..\..\..\BookStudAdd.xaml"
            this.IdBook.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.count = ((System.Windows.Controls.TextBox)(target));
            
            #line 190 "..\..\..\BookStudAdd.xaml"
            this.count.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged5);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 191 "..\..\..\BookStudAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 192 "..\..\..\BookStudAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

