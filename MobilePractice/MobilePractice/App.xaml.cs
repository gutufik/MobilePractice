using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilePractice.Data;
using System.IO;

namespace MobilePractice
{
    public partial class App : Application
    {
        public static User User { get; set; }
        public const string DATABASE_NAME = "DB";
        public static LocalRepository dataBase;
        public static LocalRepository DB
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new LocalRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.AuthorizationPage());
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
