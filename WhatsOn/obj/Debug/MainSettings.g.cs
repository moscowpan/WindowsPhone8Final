﻿#pragma checksum "C:\Users\Christine\Documents\Visual Studio 2012\Projects\WhatsOn\WhatsOn\MainSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "41CF72D78C5821BE4F0A58031DE10823"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WhatsOn {
    
    
    public partial class MainSettings : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image imageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button changePostalCode;
        
        internal System.Windows.Controls.TextBlock SetPostalCode;
        
        internal System.Windows.Controls.TextBlock PostalCodeSet;
        
        internal System.Windows.Controls.TextBlock ValidPC;
        
        internal System.Windows.Controls.Button changeProvider;
        
        internal System.Windows.Controls.TextBlock SetProvider;
        
        internal System.Windows.Controls.TextBlock ProviderSet;
        
        internal System.Windows.Controls.TextBlock IsValidPC;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhatsOn;component/MainSettings.xaml", System.UriKind.Relative));
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.imageTitle = ((System.Windows.Controls.Image)(this.FindName("imageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.changePostalCode = ((System.Windows.Controls.Button)(this.FindName("changePostalCode")));
            this.SetPostalCode = ((System.Windows.Controls.TextBlock)(this.FindName("SetPostalCode")));
            this.PostalCodeSet = ((System.Windows.Controls.TextBlock)(this.FindName("PostalCodeSet")));
            this.ValidPC = ((System.Windows.Controls.TextBlock)(this.FindName("ValidPC")));
            this.changeProvider = ((System.Windows.Controls.Button)(this.FindName("changeProvider")));
            this.SetProvider = ((System.Windows.Controls.TextBlock)(this.FindName("SetProvider")));
            this.ProviderSet = ((System.Windows.Controls.TextBlock)(this.FindName("ProviderSet")));
            this.IsValidPC = ((System.Windows.Controls.TextBlock)(this.FindName("IsValidPC")));
        }
    }
}
