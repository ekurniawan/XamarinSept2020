using ContohXamarinSep2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarinSep2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingToDataModel : ContentPage
    {
        public BindingToDataModel()
        {
            InitializeComponent();
            List<ListItem> lstItem = new List<ListItem>
            {
                new ListItem
                {
                    Title="Xamarin for Android",
                    Description = "Belajar Xamarin for Android"
                },
                new ListItem
                {
                    Title="Xamarin for IOS",
                    Description = "Belajar Xamarin for IOS"
                },
                new ListItem
                {
                    Title = "Xamarin Forms",
                    Description = "Belajar Xamarin Forms"
                }
            };

            lvItems.ItemsSource = lstItem;
        }

        private async void lvItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (ListItem)e.Item;
            await DisplayAlert($"{data.Title}", $"{data.Description}", "OK");
        }
    }
}