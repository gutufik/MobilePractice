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
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
            Date.MinimumDate = DateTime.Now;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var product = new Data.Product {Name = Name.Text };
            App.DB.SaveProduct(product);
            Navigation.PopAsync();
        }
    }
}