using FirstAppliXamarinForm.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppliXamarinForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageMenu());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
