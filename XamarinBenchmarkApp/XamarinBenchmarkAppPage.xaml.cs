using System;
using Xamarin.Forms;

namespace XamarinBenchmarkApp
{
    public partial class XamarinBenchmarkAppPage : ContentPage
    {
        public XamarinBenchmarkAppPage()
        {
            InitializeComponent();
        }

        async void openListBenchmark(object sender, EventArgs args)
        {
            var newPage = new ListViewPage();
            await Navigation.PushAsync(newPage);
        }

        async void openHttpBenchmark(object sender, EventArgs args)
        {
            var newPage = new HttpPage();
            await Navigation.PushAsync(newPage);
        }

        async void openStorageBenchmark(object sender, EventArgs args)
        {
            var newPage = new StoragePage();
            await Navigation.PushAsync(newPage);
        }

        async void openViewStackBenchmark(object sender, EventArgs args)
        {
            var newPage = new ViewStackPage();
            await Navigation.PushAsync(newPage);
        }

        async void openChartBenchmark(object sender, EventArgs args)
        {
            var newPage = new ChartPage();
            await Navigation.PushAsync(newPage);
        }
    }
}
