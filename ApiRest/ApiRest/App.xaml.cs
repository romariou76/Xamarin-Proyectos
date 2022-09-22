﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiRest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new MainPage());
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
