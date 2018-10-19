using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ScrollBarBug.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ScrollBarBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EffectPage();
            //MainPage = new RendererPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
