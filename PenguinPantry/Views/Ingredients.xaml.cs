namespace PenguinPantry.Views;

public partial class Ingredients : ContentPage
{
	public Ingredients()
	{
		InitializeComponent();
		foo.ItemsSource = RequestsClient.Ingredients;
	}

}

