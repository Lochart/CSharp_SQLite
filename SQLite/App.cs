using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLite
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "animes.db";
        public static Anime_Command database;
        public static Anime_Command Database
        {
            get
            {
                if (database == null)
                    database = new Anime_Command(DATABASE_NAME);
               
                return database;
            }
        }

        public App()
        {
            MainPage = new NavigationPage(new Main_Page());
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
