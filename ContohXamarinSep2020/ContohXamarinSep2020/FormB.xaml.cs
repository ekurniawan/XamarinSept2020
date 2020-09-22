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
    public partial class FormB : ContentPage
    {
        public FormB()
        {
            InitializeComponent();
        }

        private string _data;
        public FormB(string data)
        {
            InitializeComponent();
            _data = data;
            lblData.Text = $"Data yg diterima: {_data}";
        }

        private void btnGetGlobal_Clicked(object sender, EventArgs e)
        {
            lblData.Text = Global.Instance.myData;
        }

        private async void btnGetPref_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("my_data"))
            {
                Preferences.Set("my_data", "Hello Xamarin");
                await DisplayAlert("Keterangan", $"Pref diubah", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", $"Preference tidak ditemukan",
                    "OK");
            }
        }
    }
}