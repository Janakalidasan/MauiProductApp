using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiProductApp.Models;
using MauiProductApp.Services;

namespace MauiProductApp.ViewModels;

public class ProductDetailViewModel : INotifyPropertyChanged
{
    private readonly ProductService _service = new();
    private Product _product;

    public Product Product
    {
        get => _product;
        set
        {
            _product = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public async Task LoadProduct(int id)
    {
        Product = await _service.GetProductByIdAsync(id);
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
