using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Apu.Models
{
    /// <summary>
    /// Cookbook model
    /// </summary>
    public class CookBook : Book
    {
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
