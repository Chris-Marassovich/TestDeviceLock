using System;
using System.Collections.Generic;
using TestDeviceLock.ViewModels;
using TestDeviceLock.Views;
using Xamarin.Forms;

namespace TestDeviceLock
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
