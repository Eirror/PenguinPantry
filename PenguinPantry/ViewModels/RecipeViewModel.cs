using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PenguinPantry.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinPantry.ViewModels
{
    public partial class RecipeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Recipe> recipes;

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>(RequestsClient.Recipes.GetRange(0, 10));
            GetRecipes();
        }

        [RelayCommand]
        async Task GetRecipes()
        {

        }

        [RelayCommand]
        async Task ViewRecipeCommand()
        {
            //Shell.Current.GoToAsync(nameof());
        }

    }
}
