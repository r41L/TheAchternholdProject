using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace UrbanInvoicing
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new UrbanInvoicing.MainPage();
		}

		protected override void OnStart ()
		{
            ThreadStart ThreadStarter = new ThreadStart(StartApp);
            Thread StartThread = new Thread(ThreadStarter);
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        private void StartApp()
        {
            string tmpString = String.Empty;
            // Test?
        }
	}
}
