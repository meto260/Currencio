﻿#pragma checksum "..\..\..\CalcUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14EABEE06778A67F638D14CFEF45083A90F1337E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Currencio;
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


namespace Currencio {
    
    
    /// <summary>
    /// CalcUC
    /// </summary>
    public partial class CalcUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CalcUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox input1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CalcUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox input2;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CalcUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pairLBL;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Currencio;component/calcuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CalcUC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\CalcUC.xaml"
            ((Currencio.CalcUC)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.input1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\CalcUC.xaml"
            this.input1.GotFocus += new System.Windows.RoutedEventHandler(this.input1_GotFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\CalcUC.xaml"
            this.input1.KeyUp += new System.Windows.Input.KeyEventHandler(this.input1_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.input2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\CalcUC.xaml"
            this.input2.GotFocus += new System.Windows.RoutedEventHandler(this.input1_GotFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\CalcUC.xaml"
            this.input2.KeyUp += new System.Windows.Input.KeyEventHandler(this.input2_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pairLBL = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
