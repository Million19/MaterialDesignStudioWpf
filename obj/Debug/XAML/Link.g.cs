﻿#pragma checksum "..\..\..\XAML\Link.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "731DDC3B80D2EE5985B1F25C558D8AAA677B8D78"
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


namespace WPF_WYSIWYG_HTML_Editor {
    
    
    /// <summary>
    /// Link
    /// </summary>
    public partial class Link : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\XAML\Link.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPF_WYSIWYG_HTML_Editor.Link addLink;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\XAML\Link.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\XAML\Link.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox link;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\XAML\Link.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOK;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\XAML\Link.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF WYSIWYG HTML Editor;component/xaml/link.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\XAML\Link.xaml"
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
            this.addLink = ((WPF_WYSIWYG_HTML_Editor.Link)(target));
            
            #line 4 "..\..\..\XAML\Link.xaml"
            this.addLink.Initialized += new System.EventHandler(this.addLink_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.link = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 10 "..\..\..\XAML\Link.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonOK = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\XAML\Link.xaml"
            this.ButtonOK.Click += new System.Windows.RoutedEventHandler(this.ButtonOK_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\XAML\Link.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

