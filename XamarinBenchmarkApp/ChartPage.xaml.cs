using System;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;

namespace XamarinBenchmarkApp
{
    public partial class ChartPage : ContentPage
    {

        public ChartPage()
        {
            InitializeComponent();

            Content = new PlotView
            {
                Model = new PlotModel { 
                    Title = "Hello, Forms!"                    
                },
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
            };

        }


    }
}
