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
    public partial class ContohGridLayout : ContentPage
    {
        public ContohGridLayout()
        {
            InitializeComponent();
        }

        private void prosesHitung_Clicked(object sender, EventArgs e)
        {
            var bil1 = Convert.ToDouble(entryBil1.Text);
            var bil2 = Convert.ToDouble(entryBil2.Text);
            double hasil = 0;
            var myBtn = (Button)sender;
            switch (myBtn.Text)
            {
                case "Tambah":
                    hasil = bil1 + bil2;
                    break;
                case "Kurang":
                    hasil = bil1 - bil2;
                    break;
                case "Bagi":
                    hasil = bil1 / bil2;
                    break;
                case "Kali":
                    hasil = bil1 * bil2;
                    break;
            }
            entryHasil.Text = hasil.ToString();
        }
    }
}