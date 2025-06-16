using MauiProductApp.Models;

namespace MauiProductApp.Views;

public partial class ProductListPage : ContentPage
{
    public ProductListPage()
    {
        InitializeComponent();
    }

    private async void OnProductSelected(object sender, EventArgs e)
    {
        var product = (sender as BindableObject)?.BindingContext as Product;
        if (product != null)
        {
            await Shell.Current.GoToAsync(nameof(ProductDetailPage), new Dictionary<string, object>
            {
                ["Product"] = product
            });
        }
    }

}
