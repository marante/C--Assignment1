namespace Assignment1_Apu
{
    /// <summary>
    /// Ingredient model
    /// </summary>
    public class Ingredient
    {
        public string Name { get; set; }
        public float Amount { get; set; }

        public string DisplayIngredient => $"{Amount} \t {Name}";
    }
}
