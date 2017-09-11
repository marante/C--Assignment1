using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1_Apu.Enums;
using Assignment1_Apu.Models;
using Assignment1_Apu.HelperMethods;

namespace Assignment1_Apu
{
    public partial class FormMain : Form
    {
        CookBook cookBook = new CookBook();
        List<Ingredient> ingredients = new List<Ingredient>();

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
          FormIngredient ingredientForm = new FormIngredient(this, (Recipe) RecipeListbox.SelectedItem);
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
            var selRecipe = (Recipe) RecipeListbox.SelectedItem;
            RecipeListbox.Items.Remove(RecipeListbox.SelectedItem);
            cookBook.Recipes.Remove(selRecipe);
        }

        /// <summary>
        /// Appends items to the Recipelist.
        /// </summary>
        void UpdateCookBook(Recipe rec)
        {
            RecipeListbox.Items.Add(rec);
        }

        /// <summary>
        /// Method for clearing the inputs when a recipe is added.
        /// </summary>
        void ClearForm()
        {
            RecipeNameTextBox.Clear();
            RecipeTextbox.Clear();
        }

        public void SendIngredients(List<Ingredient> ingredientList)
        {
            ingredients = ingredientList;
        }

        void AddRecipe()
        {
            // Initializing an instance of recipe.
            Recipe recipe = new Recipe()
            {
                Name = RecipeNameTextBox.Text,
                Description = RecipeTextbox.Text,
                NumOfIngredients = ingredients.Count(),
                Dish = (Dish)RecipeDropdownCategory.SelectedIndex,
                MealType = (MealType)MealTypeDropdownList.SelectedIndex,
                Ingredients = ingredients
            };

            // Adding the recipe to the cookbook and updating the Recipe list
            cookBook.Recipes.Add(recipe);
            UpdateCookBook(recipe);
            ClearForm();
        }

        // TODO Kolla om detta funkar, vet inte riktigt..
        /// <summary>
        /// Validation for when users try to delete/edit when nothing is selected.
        /// </summary>
        void IfNoItemSelected()
        {
            if (RecipeListbox.SelectedItem == null)
            {
                MessageBox.Show("Fix exception that comes after mbox");
                return;
            }
        }
    }
}