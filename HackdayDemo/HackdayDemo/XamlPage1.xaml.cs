using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HackdayDemo
{
    public partial class XamlPage1 : ContentPage
    {
        public XamlPage1()
        {
            InitializeComponent();


            var items = new List<TwitterItem>();

            items.Add(new TwitterItem()
            {
                Name = "Bill Gates",
                Twitter = "@BillGates",
                ImageUri = "bill.jpg"
            });

            items.Add(new TwitterItem()
            {
                Name = "Scott Hanselmann",
                Twitter = "@shanselman",
                ImageUri = "scott.jpg"
            });

            items.Add(new TwitterItem()
            {
                Name = "Mark Russinovich",
                Twitter = "@markrussinovch",
                ImageUri = "mark.jpg"
            });

            listView.ItemsSource = items;

            listView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selected", "You have selected an item!", "OK!");
        }
    }

    public class TwitterItem
    {
        public string Name { get; set; }
        public string Twitter { get; set; }
        public string ImageUri { get; set; }
    }
}
