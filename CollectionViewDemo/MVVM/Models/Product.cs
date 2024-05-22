namespace CollectionViewDemo.MVVM.Models;

public class Product
{
    public required string Name { get; set; }

    public decimal Price { get; set; }

    public required string Image { get; set; }

    public int Stock { get; set; }

    public bool HasOffer { get; set; }

    public decimal OfferPrice { get; set; }

}
