﻿#pragma checksum "..\..\..\..\UI\TicketDetailDlg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A57AB3A22E744F5A3A431A16D4B155B0C2F83317"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using Ticketsystem_WPF;


namespace Ticketsystem_WPF {
    
    
    /// <summary>
    /// TicketDetailDlg
    /// </summary>
    public partial class TicketDetailDlg : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btOK;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAbbrechen;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKunde;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBeschreibung;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStatus;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btKundeHinzufuegen;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UI\TicketDetailDlg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDatum;
        
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
            System.Uri resourceLocater = new System.Uri("/Ticketsystem_WPF_DB_DataBinding;component/ui/ticketdetaildlg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\TicketDetailDlg.xaml"
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
            this.btOK = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\UI\TicketDetailDlg.xaml"
            this.btOK.Click += new System.Windows.RoutedEventHandler(this.btOK_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btAbbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\UI\TicketDetailDlg.xaml"
            this.btAbbrechen.Click += new System.Windows.RoutedEventHandler(this.btAbbrechen_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbKunde = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.tbBeschreibung = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btKundeHinzufuegen = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\UI\TicketDetailDlg.xaml"
            this.btKundeHinzufuegen.Click += new System.Windows.RoutedEventHandler(this.btKundeHinzufuegen_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblDatum = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

