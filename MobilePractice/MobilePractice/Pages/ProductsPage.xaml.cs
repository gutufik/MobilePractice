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
    public partial class ProductsPage : ContentPage
    {
        public List<Product> Products { get; set; }
        public ProductsPage()
        {
            InitializeComponent();
            Products = App.DB.GetProducts();

            BindingContext = this;

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ProductPage());
        }

        private void lvProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new Pages.ProductPage());
        }
    }
}