﻿#pragma checksum "..\..\..\AddStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0284C33C4A9B50BF642656CF49251641ED940794"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// AddStudent
    /// </summary>
    public partial class AddStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 186 "..\..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surname;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox group;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adress;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.16.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ll;V1.0.0.0;component/addstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddStudent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.16.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\AddStudent.xaml"
            ((ll.AddStudent)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.surname = ((System.Windows.Controls.TextBox)(target));
            
            #line 186 "..\..\..\AddStudent.xaml"
            this.surname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            
            #line 187 "..\..\..\AddStudent.xaml"
            this.name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.group = ((System.Windows.Controls.TextBox)(target));
            
            #line 188 "..\..\..\AddStudent.xaml"
            this.group.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged3);
            
            #line default
            #line hidden
            return;
            case 5:
            this.phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 189 "..\..\..\AddStudent.xaml"
            this.phone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged4);
            
            #line default
            #line hidden
            return;
            case 6:
            this.adress = ((System.Windows.Controls.TextBox)(target));
            
            #line 190 "..\..\..\AddStudent.xaml"
            this.adress.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged5);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 191 "..\..\..\AddStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 192 "..\..\..\AddStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
