using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OlaMundoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Olha o que aconteceu no OnStart!!");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Olha o que aconteceu no OnSleep!!");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("Olha o que aconteceu no OnResume!!");
        }
    }
}
