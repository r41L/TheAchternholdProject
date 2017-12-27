using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace UrbanInvoicing
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        async void ButtonExportClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new InvoiceExport());
        }

        async void ButtonImportClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new InvoiceImport());
        }

        async void ButtonOverviewClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Overview());
        }

        async void ButtonContactsClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Contacts());
        }
    }
}
