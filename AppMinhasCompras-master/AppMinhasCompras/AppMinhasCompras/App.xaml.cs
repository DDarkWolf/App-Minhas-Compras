using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using AppMinhasCompras.Helper;

namespace AppMinhasCompras
{
    public partial class App : Application
    {


        static SQLiteDataBaseHelper database;

        public static SQLiteDataBaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData), "arquivo.db3");

                    database = new SQLiteDataBaseHelper(path);
                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.PaginaPrincipal());
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
