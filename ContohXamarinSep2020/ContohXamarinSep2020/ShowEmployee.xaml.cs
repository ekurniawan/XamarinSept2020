using ContohXamarinSep2020.DAL;
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
    public partial class ShowEmployee : ContentPage
    {
        private EmployeeDAL _empDAL;
        public ShowEmployee()
        {
            InitializeComponent();
            _empDAL = new EmployeeDAL();
        }

        private void RefreshData()
        {
            var results = _empDAL.GetAll();
            lvEmployee.ItemsSource = results;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            RefreshData();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeeSQL());
        }

        private async void lvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (Employee)e.Item;
            var formEdit = new EditEmployeeSQL();
            formEdit.BindingContext = data;
            await Navigation.PushAsync(formEdit);
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var myBtn = (Button)sender;
            var delEmp = new Employee
            {
                EmpId = Convert.ToInt32(myBtn.CommandParameter)
            };
            try
            {
                var answer = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk delete data?", "Yes", "No");
                if (answer)
                {
                    _empDAL.Delete(delEmp);
                    await DisplayAlert("Keterangan", $"ID: {myBtn.CommandParameter} berhasil di delete", "OK");
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"{ex.Message}", "OK");
            }
           
        }
    }
}