using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace LoanCalculator
{
    public partial class MainPage : UserControl
    {
        private const double Percentage = 0.0345;

        public MainPage()
        {
            InitializeComponent();

            AmountSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(AmountSlider_ValueChanged);
            YearsSlider.ValueChanged += (sender, args) =>
                                            {
                                                YearsSlider.Value = Math.Round(args.NewValue);
                                            };
        }

        private void AmountSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AmountSlider.Value = Math.Round(e.NewValue);
        }

        private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
        {
            var requestedAmount = AmountSlider.Value;
            var requestedYears = (int) YearsSlider.Value;

            for (var i = 0; i < requestedYears; i++)
            {
                requestedAmount += requestedAmount*Percentage;
            }

            var monthlyPayback = requestedAmount/(requestedYears*12);
            PaybackTextBlock.Text = String.Format("€{0}", Math.Round(monthlyPayback, 2));
        }

        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
