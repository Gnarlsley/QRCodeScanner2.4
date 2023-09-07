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
            });
            ScannerView.IsAnalyzing = false;
        }

        private void scan_button_Pressed(object sender, EventArgs e)
        {
            ScannerView.IsScanning = true;
            ScannerView.IsAnalyzing = true;
        }
    }
}