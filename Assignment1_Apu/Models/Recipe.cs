using Assignment1_Apu.Enums;
using System.Collections.Generic;

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

        public string DisplayString => $"{Name} \t\t\t {NumOfIngredients} \t {MealType} \t {Dish} \t {Description}";
    }
}
