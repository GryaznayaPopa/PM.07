﻿#pragma checksum "..\..\ContractWindowList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22CF0A8E5881BEBC792D58522D7DC61FA3822C41"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgrammCourse;
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


namespace ProgrammCourse {
    
    
    /// <summary>
    /// ContractWindowList
    /// </summary>
    public partial class ContractWindowList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\ContractWindowList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridContract;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ContractWindowList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackMenuContrButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ContractWindowList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButtonContract;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ContractWindowList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelUserFIO;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ContractWindowList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageUser;
        
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
            System.Uri resourceLocater = new System.Uri("/ProgrammCourse;component/contractwindowlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ContractWindowList.xaml"
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
            this.dataGridContract = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BackMenuContrButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ContractWindowList.xaml"
            this.BackMenuContrButton.Click += new System.Windows.RoutedEventHandler(this.BackMenuContrButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitButtonContract = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ContractWindowList.xaml"
            this.ExitButtonContract.Click += new System.Windows.RoutedEventHandler(this.ExitButtonContract_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LabelUserFIO = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ImageUser = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
