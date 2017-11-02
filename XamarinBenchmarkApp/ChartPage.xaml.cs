using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms;

namespace XamarinBenchmarkApp
{
    public partial class ChartPage : ContentPage
    {

        public ChartPage()
        {
            InitializeComponent();

        }

        void RenderChart(object sender, EventArgs e)
        {
            var plotModel = new PlotModel { Title = "Chart Benchmark" };

            var series1 = new LineSeries
            {
                MarkerType = OxyPlot.MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyPlot.OxyColors.White
            };
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                series1.Points.Add(new DataPoint(i, rnd.NextDouble() * (100 - 1) + 1));
            }

            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Maximum = 100, Minimum = 0 });

            plotModel.Series.Add(series1);

            Content = new PlotView
            {
                Model = plotModel,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
            };
        }


    }
}
