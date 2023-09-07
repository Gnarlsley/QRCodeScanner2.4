using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRCodeScanner2._4.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResult.Text = result.Text;
                if (scanResult.Text != null)
                {
                    save_button.IsVisible = true;
                }
            });
            ScannerView.IsAnalyzing = false;
        }

        private void scan_button_Pressed(object sender, EventArgs e)
        {
            ScannerView.IsScanning = true;
            ScannerView.IsAnalyzing = true;
        }

        private void save_button_Pressed(object sender, EventArgs e)
        {

            save_button.IsVisible = false;
            scanResult.Text = "";
        }
    }
}