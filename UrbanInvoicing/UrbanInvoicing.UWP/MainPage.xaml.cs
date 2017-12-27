using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UrbanInvoicing.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new UrbanInvoicing.App());
        }

        private void ButtonInvoiceExportClicked_Click(object sender, RoutedEventArgs e)
        {
            InvoiceExport tmpInvoiceExportPage = new InvoiceExport();
            
        }

        private void ButtonInvoiceImportClicked_Click(object sender, RoutedEventArgs e)
        {
            InvoiceExport tmpInvoiceExportPage = new InvoiceExport();

        }

        private void ButtonOverviewClicked_Click(object sender, RoutedEventArgs e)
        {
            InvoiceExport tmpInvoiceExportPage = new InvoiceExport();

        }

        private void ButtonContactsClicked_Click(object sender, RoutedEventArgs e)
        {
            InvoiceExport tmpInvoiceExportPage = new InvoiceExport();

        }
    }
}
