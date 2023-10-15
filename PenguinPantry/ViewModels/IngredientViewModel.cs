﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinPantry.ViewModels
{
    public partial class IngredientViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<string> ingredients;

        public IngredientViewModel()
        {
            Ingredients = RequestsClient.Ingredients;
        }
    }
}
