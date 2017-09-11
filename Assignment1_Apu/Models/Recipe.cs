using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_Apu.Enums;

namespace Assignment1_Apu
{
    /// <summary>
    /// Recipe model
    /// </summary>
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumOfIngredients { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public Dish Dish { get; set; }
        public MealType MealType { get; set; }

        public string DisplayString => $"{Name} {NumOfIngredients} {MealType} {Dish} {Description}";
    }
}
