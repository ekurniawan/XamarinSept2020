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
    public partial class BindingViewData : ContentPage
    {
        public BindingViewData()
        {
            InitializeComponent();

            List<ListItem> lstItem = new List<ListItem>
            {
                new ListItem
                {
                    ID=1,
                    Title="Xamarin for Android",
                    Description = "Belajar Xamarin for Android",
                    Source = "monkey1.png",
                    Price = 300000
                },
                new ListItem
                {
                    ID=2,
                    Title="Xamarin for IOS",
                    Description = "Belajar Xamarin for IOS",
                    Source = "monkey2.png",
                    Price = 400000
                },
                new ListItem
                {
                    ID=3,
                    Title = "Xamarin Forms",
                    Description = "Belajar Xamarin Forms",
                    Source = "monkey3.png",
                    Price = 700000
                },
            };

            lvData.ItemsSource = lstItem;
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (ListItem)e.Item;
            await DisplayAlert(
                $"{data.Title}", $"Deskripsi: {data.Description} Price: {data.Price}", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var myBtn = (Button)sender;
            await DisplayAlert("Keterangan", $"ID yang dipilih: {myBtn.CommandParameter}",
                "OK");
        }
    }
}