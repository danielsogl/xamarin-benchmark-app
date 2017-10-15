using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinBenchmarkApp
{

    public class ListData
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public partial class ListViewPage : ContentPage
    {

        ObservableCollection<ListData> listItems;
        int id = 1;

        public ListViewPage()
        {
            InitializeComponent();
            ListView.ItemsSource = listItems;
        }

        public ObservableCollection<ListData> BuildData(int count = 1000)
        {

            ObservableCollection<ListData> items = new ObservableCollection<ListData>();

            string[] adjectives = { "pretty", "large", "big", "small", "tall", "short", "long", "handsome", "plain", "quaint", "clean", "elegant", "easy", "angry", "crazy", "helpful", "mushy", "odd", "unsightly", "adorable", "important", "inexpensive", "cheap", "expensive", "fancy" };
            string[] colours = { "red", "yellow", "blue", "green", "pink", "brown", "purple", "brown", "white", "black", "orange" };
            string[] nouns = { "table", "chair", "house", "bbq", "desk", "car", "pony", "cookie", "sandwich", "burger", "pizza", "mouse", "keyboard" };

            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                items.Add(new ListData { id = id, label = adjectives[rnd.Next(0, adjectives.Length)] + " " + colours[rnd.Next(0, colours.Length)] + " " + nouns[rnd.Next(0, nouns.Length)] });
                id++;
            }

            return items;
        }

        void Run(object sender, System.EventArgs e)
        {
            listItems = BuildData();
            ListView.ItemsSource = listItems;
        }

        void RunLots(object sender, System.EventArgs e)
        {
            listItems = BuildData(10000);
            ListView.ItemsSource = listItems;
        }

        void AddItems(object sender, System.EventArgs e)
        {
            ObservableCollection<ListData> moreItems = BuildData();

            for (int i = 0; i < moreItems.Count; i++)
            {
                listItems.Add(moreItems[i]);
            }
        }

        void Update(object sender, System.EventArgs e)
        {
            for (int i = 0; i < listItems.Count; i += 10)
            {
                listItems[i].label += "!!!";
            }
        }

        void Clear(object sender, System.EventArgs e)
        {
            listItems.Clear();
        }

    }
}
