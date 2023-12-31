﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QRCodeScanner2._4.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Scanner";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}