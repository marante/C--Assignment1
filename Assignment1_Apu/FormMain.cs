using Assignment1_Apu.Enums;
using Assignment1_Apu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormMain : Form
    {
        private readonly CookBook _cookBook = new CookBook();
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method for adding recipes to the CookBook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAdd_Click(object sender, EventArgs e)
        {
            AddRecipe();
        }

        /// <summary>
        /// Method for adding ingredients to a given recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredient ingredientForm = new FormIngredient(this);
            ingredientForm.Show();
        }

        /// <summary>
        /// Method for editing the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditRecipe_Click(object sender, EventArgs e)
        {
            IfNoItemSelected();
            FormIngredient ingredientForm = new FormIngredient(this, (Recipe)RecipeListbox.SelectedItem);
            ingredientForm.Show();
        }

        /// <summary>
        /// Method for deleting the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            IfNoItemSelected();
            var selRecipe = (Recipe)RecipeListbox.SelectedItem;
            RecipeListbox.Items.Remove(RecipeListbox.SelectedItem);
            _cookBook.Recipes.Remove(selRecipe);
        }

        /// <summary>
        /// Appends items to the Recipelist.
        /// </summary>
        private void UpdateCookBook(Recipe rec)
        {
            RecipeListbox.Items.Add(rec);
        }

        /// <summary>
        /// Method for clearing the inputs when a recipe is added.
        /// </summary>
        private void ClearForm()
        {
            RecipeNameTextBox.Clear();
            RecipeTextbox.Clear();
        }

        public void SendIngredients(List<Ingredient> ingredientList)
        {
            _ingredients = ingredientList;
        }

        private void AddRecipe()
        {
            // Initializing an instance of recipe.
            Recipe recipe = new Recipe()
            {
                Name = RecipeNameTextBox.Text,
                Description = RecipeTextbox.Text,
                NumOfIngredients = _ingredients.Count(),
                Dish = (Dish)RecipeDropdownCategory.SelectedIndex,
                MealType = (MealType)MealTypeDropdownList.SelectedIndex,
                Ingredients = _ingredients
            };

            // Adding the recipe to the cookbook and updating the Recipe list
            _cookBook.Recipes.Add(recipe);
            UpdateCookBook(recipe);
            ClearForm();
        }

        // TODO Kolla om detta funkar, vet inte riktigt..
        /// <summary>
        /// Validation for when users try to delete/edit when nothing is selected.
        /// </summary>
        private void IfNoItemSelected()
        {
            if (RecipeListbox.SelectedItem == null)
            {
                MessageBox.Show("Fix exception that comes after mbox");
            }
        }
    }
}