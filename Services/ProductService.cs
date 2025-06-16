using MauiProductApp.Models;
using System.Net.Http.Json;

namespace MauiProductApp.Services;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Product>>("https://fakestoreapi.com/products");
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Product>($"https://fakestoreapi.com/products/{id}");
    }
}
