﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarinSep2020
{
    public partial class App : Application
    {
        //
        public App()
        {
            InitializeComponent();
            MainPage = new MyMasterPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
