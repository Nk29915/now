﻿#pragma checksum "..\..\..\Windows_\Autorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9A2816539873D0459D395954167005AC3C77236F00AA05E6794B099B632C5768"
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
using _3121Sr.Windows_;


namespace _3121Sr.Windows_ {
    
    
    /// <summary>
    /// Autorization
    /// </summary>
    public partial class Autorization : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Log;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasB;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Sp_Discription;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMB_quest;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Otvet;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows_\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Result;
        
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
            System.Uri resourceLocater = new System.Uri("/3121Sr;component/windows_/autorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows_\Autorization.xaml"
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
            this.TB_Log = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Windows_\Autorization.xaml"
            this.TB_Log.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Log_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PasB = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            
            #line 30 "..\..\..\Windows_\Autorization.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\Windows_\Autorization.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Sp_Discription = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.CMB_quest = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.TB_Otvet = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Windows_\Autorization.xaml"
            this.TB_Otvet.KeyDown += new System.Windows.Input.KeyEventHandler(this.TB_Otvet_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TB_Result = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 44 "..\..\..\Windows_\Autorization.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

