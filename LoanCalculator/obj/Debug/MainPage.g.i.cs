﻿#pragma checksum "D:\development\UnitTests\Silverlight\LoanCalculator\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0A63B1D40A293EA5126F9B870717BA8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace LoanCalculator {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid LoanCalculationsGrid;
        
        internal System.Windows.Controls.TextBlock TitleTextBlock;
        
        internal System.Windows.Controls.TextBlock InterestTextBlock;
        
        internal System.Windows.Controls.Slider AmountSlider;
        
        internal System.Windows.Controls.TextBlock AmountTextBlock;
        
        internal System.Windows.Controls.Slider YearsSlider;
        
        internal System.Windows.Controls.TextBlock MonthTextBlock;
        
        internal System.Windows.Controls.Button CalculateButton;
        
        internal System.Windows.Controls.TextBlock PaybackTextBlock;
        
        internal System.Windows.Controls.Button OkButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LoanCalculator;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.LoanCalculationsGrid = ((System.Windows.Controls.Grid)(this.FindName("LoanCalculationsGrid")));
            this.TitleTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TitleTextBlock")));
            this.InterestTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("InterestTextBlock")));
            this.AmountSlider = ((System.Windows.Controls.Slider)(this.FindName("AmountSlider")));
            this.AmountTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("AmountTextBlock")));
            this.YearsSlider = ((System.Windows.Controls.Slider)(this.FindName("YearsSlider")));
            this.MonthTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("MonthTextBlock")));
            this.CalculateButton = ((System.Windows.Controls.Button)(this.FindName("CalculateButton")));
            this.PaybackTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("PaybackTextBlock")));
            this.OkButton = ((System.Windows.Controls.Button)(this.FindName("OkButton")));
        }
    }
}

