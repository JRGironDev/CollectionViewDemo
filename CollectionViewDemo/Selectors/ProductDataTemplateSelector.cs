using CollectionViewDemo.MVVM.Models;

namespace CollectionViewDemo.Selectors;

public class ProductDataTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        Product? product = item as Product;

        if (product != null && !product.HasOffer)
        {
            Application
                .Current
                .Resources
                .TryGetValue("ProductStyle", out object productStyle);

            return productStyle as DataTemplate;
        }
        else
        {
            Application
                .Current
                .Resources
                .TryGetValue("OfferStyle", out object offerStyle);

            return offerStyle as DataTemplate;
        }
    }
}
