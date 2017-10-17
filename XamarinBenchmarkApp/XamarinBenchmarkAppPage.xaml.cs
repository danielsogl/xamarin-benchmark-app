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

        async void OpenListBenchmark(object sender, EventArgs args)
        {
            var newPage = new ListViewPage();
            await Navigation.PushAsync(newPage);
        }

        async void OpenHttpBenchmark(object sender, EventArgs args)
        {
            var newPage = new HttpPage();
            await Navigation.PushAsync(newPage);
        }

        async void OpenStorageBenchmark(object sender, EventArgs args)
        {
            var newPage = new StoragePage();
            await Navigation.PushAsync(newPage);
        }

        async void OpenViewStackBenchmark(object sender, EventArgs args)
        {
            var newPage = new ViewStackPage();
            await Navigation.PushAsync(newPage);
        }

        async void OpenChartBenchmark(object sender, EventArgs args)
        {
            var newPage = new ChartPage();
            await Navigation.PushAsync(newPage);
        }
    }
}
