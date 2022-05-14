using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilePractice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.RegistrationPage());
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            var login = etrLogin.Text;
            var password = etrPassword.Text;
            App.User = App.DB.GetUser(login, password);


            if (App.User != null)
                Navigation.PushAsync(new Pages.ProductsPage());
            else
                DisplayAlert("Error", "Incorrect login or password", "Ok");
        }
    }
}