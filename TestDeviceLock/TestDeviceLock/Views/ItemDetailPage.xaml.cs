using System.ComponentModel;
using TestDeviceLock.ViewModels;
using Xamarin.Forms;

namespace TestDeviceLock.Views
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