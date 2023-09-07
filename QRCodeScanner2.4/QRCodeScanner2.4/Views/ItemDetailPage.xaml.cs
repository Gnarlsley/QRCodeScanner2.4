using QRCodeScanner2._4.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QRCodeScanner2._4.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}