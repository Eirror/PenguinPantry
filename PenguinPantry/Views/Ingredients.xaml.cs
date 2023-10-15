namespace PenguinPantry.Views;

public partial class Ingredients : ContentPage
{
	public Ingredients()
	{
		InitializeComponent();
		foo.ItemsSource = new string[] { "Milk", "Eggs", "Butter", "Highly Irradiated Elephants" };
	}

}

