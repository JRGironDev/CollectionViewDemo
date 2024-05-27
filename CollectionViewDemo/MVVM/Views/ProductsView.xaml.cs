using System.Diagnostics;
using CollectionViewDemo.MVVM.ViewModels;

namespace CollectionViewDemo.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();

		BindingContext = new ProductsViewModel();
	}

	private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
	{
		Debug.Write(message: "------------------------------------------------");
		Debug.WriteLine($"Scrolled to {e.FirstVisibleItemIndex}");
		Debug.WriteLine($"Scrolled to {e.HorizontalOffset}");
		Debug.WriteLine($"Scrolled to {e.VerticalOffset}");
		Debug.WriteLine($"Scrolled to {e.HorizontalDelta}");
		Debug.WriteLine($"Scrolled to {e.VerticalDelta}");
		Debug.WriteLine($"Scrolled to {e.LastVisibleItemIndex}");
		Debug.WriteLine($"Scrolled to {e.CenterItemIndex}");
		Debug.Write(message: "------------------------------------------------");
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		ProductsViewModel? vm = BindingContext as ProductsViewModel;

		var product = vm?.Products.SelectMany(p => p).FirstOrDefault(x => x.Id == 10);
		collectionView.ScrollTo(product);
	}
}