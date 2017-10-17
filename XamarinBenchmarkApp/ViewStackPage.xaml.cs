using System;

using Xamarin.Forms;

namespace XamarinBenchmarkApp
{
    public partial class ViewStackPage : ContentPage
    {
        public ViewStackPage()
        {
            InitializeComponent();
        }

        async void OpenView(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ViewStackPage {Title = "View: " + (Navigation.NavigationStack.Count - 1).ToString()});
        }
    }
}
