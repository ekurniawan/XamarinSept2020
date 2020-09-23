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
    public partial class AddEmployeeSQL : ContentPage
    {
        private EmployeeDAL _empDAL;
        public AddEmployeeSQL()
        {
            InitializeComponent();
            _empDAL = new EmployeeDAL();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };

            try
            {
                _empDAL.Insert(newEmp);
                await DisplayAlert("Keterangan", 
                    $"Data Employee {newEmp.EmpName} berhasil ditambah", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"{ex.Message}", "OK");
            }
        }
    }
}