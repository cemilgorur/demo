﻿using Proje.Master;
using Proje.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proje
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyMasterPage());
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
