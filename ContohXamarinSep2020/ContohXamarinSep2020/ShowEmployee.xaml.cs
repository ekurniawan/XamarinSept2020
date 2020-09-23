using ContohXamarinSep2020.DAL;
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
    public partial class ShowEmployee : ContentPage
    {
        private EmployeeDAL _empDAL;
        public ShowEmployee()
        {
            InitializeComponent();
            _empDAL = new EmployeeDAL();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var results = _empDAL.GetAll();
            lvEmployee.ItemsSource = results;
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeeSQL());
        }
    }
}