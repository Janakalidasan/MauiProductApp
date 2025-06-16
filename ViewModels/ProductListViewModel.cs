using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiProductApp.Models;
using MauiProductApp.Services;

namespace MauiProductApp.ViewModels;

public class ProductListViewModel : INotifyPropertyChanged
{
    private readonly ProductService _service = new();

    public ObservableCollection<Product> Products { get; set; } = new();

    public event PropertyChangedEventHandler PropertyChanged;

    public ProductListViewModel()
    {
        LoadProducts();
    }

    private async void LoadProducts()
    {
        var items = await _service.GetProductsAsync();
        foreach (var item in items)
            Products.Add(item);
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
