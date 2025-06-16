using MauiProductApp.Models;
using MauiProductApp.ViewModels;

namespace MauiProductApp.Views;

[QueryProperty(nameof(Product), "Product")]
public partial class ProductDetailPage : ContentPage
{
    public Product Product { get; set; }

    public ProductDetailPage()
    {
        InitializeComponent();
        BindingContext = this; // or use a ViewModel if preferred
    }
}
