using ContohXamarinSep2020.DAL;
using ContohXamarinSep2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarinSep2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditEmployeeSQL : ContentPage
    {
        private EmployeeDAL _empDAL;
        public EditEmployeeSQL()
        {
            InitializeComponent();
            _empDAL = new EmployeeDAL();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editData = new Employee
            {
                EmpId = Convert.ToInt32(txtID.Text),
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesignation.Text,
                Qualification = txtQualification.Text
            };

            try
            {
                _empDAL.Edit(editData);
                await DisplayAlert("Keterangan", "Edit Data Berhasil", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"{ex.Message}", "OK");
            }
        }
    }
}