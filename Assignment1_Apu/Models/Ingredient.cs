using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Apu
{
    /// <summary>
    /// Ingredient model
    /// </summary>
    public class Ingredient
    {
        public string Name { get; set; }
        public float Amount { get; set; }

        public string DisplayIngredient => $"{Amount} {Name}";
    }
}
