﻿#pragma checksum "C:\Users\Christine\Documents\Visual Studio 2012\Projects\WhatsOn\WhatsOn\SearchResults.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6474E19144EA2009FDC1E7948BDA7D4E"
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
    
    
    public partial class SearchResults : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar SearchProgressBar;
        
        internal System.Windows.Controls.Image imageTitle;
        
        internal Microsoft.Phone.Controls.LongListSelector LLS;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhatsOn;component/SearchResults.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SearchProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("SearchProgressBar")));
            this.imageTitle = ((System.Windows.Controls.Image)(this.FindName("imageTitle")));
            this.LLS = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("LLS")));
        }
    }
}

