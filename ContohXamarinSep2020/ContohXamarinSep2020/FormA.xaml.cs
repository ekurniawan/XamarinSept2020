using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarinSep2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormA : ContentPage
    {
        public FormA()
        {
            InitializeComponent();
        }

        private async void btnKirim_Clicked(object sender, EventArgs e)
        {
            var data = entryData.Text;
            await Navigation.PushAsync(new FormB(data));
        }

        private async void btnSimpanGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.myData = entryData.Text;
            await Navigation.PushAsync(new FormB());
        }

        private async void btnGetPref_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("my_data"))
            {
                string data = Preferences.Get("my_data", "");
                await DisplayAlert("Keterangan", $"Pref: {data}", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", $"Preference tidak ditemukan",
                    "OK");
            }
        }
    }
}