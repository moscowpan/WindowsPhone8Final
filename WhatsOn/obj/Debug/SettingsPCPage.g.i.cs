﻿#pragma checksum "C:\Users\Christine\Documents\Visual Studio 2012\Projects\WhatsOn\WhatsOn\SettingsPCPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B854E95B5FBB1B4554DD52211F6CE42F"
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
    
    
    public partial class SettingsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image imageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid ContentGrid;
        
        internal System.Windows.Controls.RadioButton radioButton1;
        
        internal System.Windows.Controls.TextBox textBlocklocation;
        
        internal System.Windows.Controls.RadioButton radioButton2;
        
        internal System.Windows.Controls.TextBox textBoxPostalCode;
        
        internal System.Windows.Controls.ListBox listBoxSetting;
        
        internal System.Windows.Controls.Button changeProvider;
        
        internal System.Windows.Controls.TextBox ChooseProvider;
        
        internal System.Windows.Controls.TextBox ChooseProviderID;
        
        internal System.Windows.Controls.ListBox ProvList;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhatsOn;component/SettingsPCPage.xaml", System.UriKind.Relative));
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.imageTitle = ((System.Windows.Controls.Image)(this.FindName("imageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ContentGrid = ((System.Windows.Controls.Grid)(this.FindName("ContentGrid")));
            this.radioButton1 = ((System.Windows.Controls.RadioButton)(this.FindName("radioButton1")));
            this.textBlocklocation = ((System.Windows.Controls.TextBox)(this.FindName("textBlocklocation")));
            this.radioButton2 = ((System.Windows.Controls.RadioButton)(this.FindName("radioButton2")));
            this.textBoxPostalCode = ((System.Windows.Controls.TextBox)(this.FindName("textBoxPostalCode")));
            this.listBoxSetting = ((System.Windows.Controls.ListBox)(this.FindName("listBoxSetting")));
            this.changeProvider = ((System.Windows.Controls.Button)(this.FindName("changeProvider")));
            this.ChooseProvider = ((System.Windows.Controls.TextBox)(this.FindName("ChooseProvider")));
            this.ChooseProviderID = ((System.Windows.Controls.TextBox)(this.FindName("ChooseProviderID")));
            this.ProvList = ((System.Windows.Controls.ListBox)(this.FindName("ProvList")));
        }
    }
}

