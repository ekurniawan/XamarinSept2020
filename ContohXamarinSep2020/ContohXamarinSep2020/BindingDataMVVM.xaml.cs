﻿using ContohXamarinSep2020.ViewModels;
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
    public partial class BindingDataMVVM : ContentPage
    {
        public BindingDataMVVM()
        {
            InitializeComponent();
            BindingContext = new BindingDataViewModel();
        }
    }
}