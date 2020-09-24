using ContohXamarinSep2020.Services;
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
    public partial class ShowEmployeeServices : ContentPage
    {
        private EmployeeServices _empServices;
        public ShowEmployeeServices()
        {
            InitializeComponent();
            _empServices = new EmployeeServices();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                var data = await _empServices.GetAll();
                lvEmployee.ItemsSource = data;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error: {ex.Message}","OK");
            }
        }
    }
}