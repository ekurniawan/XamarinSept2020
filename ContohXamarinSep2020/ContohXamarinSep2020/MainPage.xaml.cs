using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
    }
}
