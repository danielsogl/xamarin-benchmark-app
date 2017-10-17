using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinBenchmarkApp
{
    public partial class StoragePage : ContentPage
    {

        Stopwatch stopwatch;

        public StoragePage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }


        void WriteAll(object sender, EventArgs e) {
            stopwatch.Reset();
            stopwatch.Start();

            Application.Current.Properties["items"] = "Test";

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        void WriteSingle(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Application.Current.Properties["item_" + i] = new Item(i, "Lorem Ipsum");
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        void ReadAll(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            Application.Current.Properties["items"].ToString();

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        void ReadSingle(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Application.Current.Properties["item_" + i].ToString();
            }

            stopwatch.Stop();
            Debug.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

    }

    public class Item {

        public int id { get; set; }
        public string body { get; set; }

        public Item(int id, string body) {
            this.id = id;
            this.body = body;
        }
    }
}
