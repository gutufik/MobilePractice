using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilePractice.Data;

namespace MobilePractice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            var name = etrName.Text;
            var login = etrLogin.Text;
            var password = etrPassword.Text;

            var user = new User 
            {
                Name = name,
                Login = login,
                Password = password,
            };

            App.DB.RegisterUser(user);


            Navigation.PushAsync(new Pages.ProductsPage());

        }
    }
}