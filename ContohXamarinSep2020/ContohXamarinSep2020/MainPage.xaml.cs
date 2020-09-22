using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ContohXamarinSep2020
{
    public partial class MainPage : ContentPage
    {
        //
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingListString());
        }

        private async void btnImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingImage());
        }

        private async void btnModalCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BindingToDataModel());
        }

        private async void btnSampleAlert_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Konfirmasi", "Apakah data akan di save?",
                "Yes", "No");
            if (result)
                await DisplayAlert("Keterangan", "Anda memulih Yes", "OK");
            else
                await DisplayAlert("keterangan", "Anda memilih No", "OK");
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Share link ke", "Cancel", null,
                "Twitter", "Facebook", "Instagram", "Tiktok");
            await DisplayAlert("Keterangan", $"Share to: {action}", "OK");
        }

        private async void btnFormA_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormA());
        }

        private async void btnPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("my_data", "Erick Kurniawan");
            await DisplayAlert("Keterangan", "Membuat Preferences", "OK");
        }
    }
}
