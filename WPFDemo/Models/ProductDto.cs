using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mapster;

namespace WPFDemo.Models;

public partial class ProductDto : ObservableObject
{
    private readonly Product product;

    public ProductDto(Product product)
    {
        this.product = product;
        this.product.Adapt(this);
    }

    [ObservableProperty]
    private string? id;

    [ObservableProperty]
    private string? maker;

    [ObservableProperty]
    private string? url;

    [ObservableProperty]
    private string? title;

    [ObservableProperty]
    private string? description;

    [RelayCommand]
    void Apply()
    {
        this.Adapt(this.product);
    }

    [RelayCommand]
    void Discard()
    {
        this.product.Adapt(this);
    }
}
