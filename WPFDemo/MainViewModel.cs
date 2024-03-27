using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WPFDemo.Models;

namespace WPFDemo;

public partial class MainViewModel : ObservableObject
{
    private readonly ContosoCraftsContext dbContext;

    [ObservableProperty]
    ObservableCollection<ProductDto> products = new();

    public MainViewModel()
    {
        dbContext = new ContosoCraftsContext();
        Products.Clear();
        foreach (var product in dbContext.Products)
        {
            Products.Add(new(product));
        }
    }

    [RelayCommand]
    void SaveAll()
    {
        dbContext.SaveChanges();
    }
}
