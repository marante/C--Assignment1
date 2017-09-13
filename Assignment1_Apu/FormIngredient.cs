using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form
    {
        private readonly List<Ingredient> _ingredients = new List<Ingredient>();
        private readonly FormMain _mainForm;
        public FormIngredient()
        {
            InitializeComponent();
        }

        public FormIngredient(FormMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public FormIngredient(FormMain mainForm, Recipe recipe)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Recipe rec = recipe;

            foreach (var ingredient in rec.Ingredients)
            {
                _ingredients.Add(ingredient);
                IngredientListBox.Items.Add(ingredient);
            }

            if (IngredientListBox.Items.Count > 0)
            {
                lblNumOfIngredients.Text = IngredientListBox.Items.Count.ToString();
            }
            else if (IngredientListBox.Items.Count <= 0)
            {
                lblNumOfIngredients.Text = "No ingredients have been added yet.";
            }
        }

        private void BtnIngredientOk_Click(object sender, EventArgs e)
        {
            _mainForm.SendIngredients(_ingredients);
            Close();
        }

        /// <summary>
        /// Method that cancels the current form, without saving.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngredientCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIngredientDelete_Click(object sender, EventArgs e)
        {
            var selIngredient = (Ingredient)IngredientListBox.SelectedItem;
            IngredientListBox.Items.Remove(IngredientListBox.SelectedItem);
            _ingredients.Remove(selIngredient);
        }

        /// <summary>
        /// Method for adding ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngredientAdd_Click(object sender, EventArgs e)
        {
            AddIngredient();
            ClearForm();
        }

        /// <summary>
        /// Just a method for clearing the inputfields.
        /// </summary>
        private void ClearForm()
        {
            ingredientTextbox.Text = "";
            IngredientAmount.Text = "";
        }

        /// <summary>
        /// Method for appending items, formatted, to the ingredientlist.
        /// </summary>
        void AddIngredient()
        {
            var ingredient = new Ingredient()
            {
                Amount = float.Parse(IngredientAmount.Text),
                Name = ingredientTextbox.Text
            };
            IngredientListBox.Items.Add(ingredient);
            _ingredients.Add(ingredient);
        }

        private void BtnChangePortionValues_Click(object sender, EventArgs e)
        {
            var portions = float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
            foreach (Ingredient ingredient in IngredientListBox.Items)
            {
                portions = portions < 0 ? 1 : float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
                ingredient.Amount = (ingredient.Amount * portions);
            }
            IngredientListBox.Refresh();
        }
    }
}
