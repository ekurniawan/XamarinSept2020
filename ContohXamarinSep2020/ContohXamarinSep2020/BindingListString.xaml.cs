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
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            List<string> lstNama = new List<string>
            {
                "Erick","Budi","Bambang","Ricky","Agus"
            };
            lvNama.ItemsSource = lstNama;
        }

        private async void lvNama_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string data = e.Item.ToString();
            await DisplayAlert("Keterangan",$"Anda memilih {data}","OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}