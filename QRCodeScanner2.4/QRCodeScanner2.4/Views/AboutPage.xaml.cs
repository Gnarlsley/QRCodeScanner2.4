using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
/** Name: Garrett, Parker
 * Date: 9/14/23
 * Purpose: cs file defining functions and displaying scanned url to label
 */
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

        async private void save_button_Pressed(object sender, EventArgs e)
        {
            save_button.IsVisible = false;
            await Clipboard.SetTextAsync(scanResult.Text);
        }
    }
}