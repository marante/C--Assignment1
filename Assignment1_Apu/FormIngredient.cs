using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form
    {
        private readonly List<Ingredient> _ingredients = new List<Ingredient>();
        private readonly FormMain _mainForm = null;
        private readonly Recipe _recipe = null;
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
            _recipe = recipe;

            foreach (var ingredient in _recipe.Ingredients)
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
            this._mainForm.SendIngredients(_ingredients);
            this.Close();
        }

        private void BtnIngredientCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngredientDelete_Click(object sender, EventArgs e)
        {
            var selIngredient = (Ingredient)IngredientListBox.SelectedItem;
            IngredientListBox.Items.Remove(IngredientListBox.SelectedItem);
            _ingredients.Remove(selIngredient);
        }

        private void BtnIngredientAdd_Click(object sender, EventArgs e)
        {
            AddIngredient();
            ingredientTextbox.Text = "";
            IngredientAmount.Text = "";
        }

        /// <summary>
        /// Method for appending items, formatted, to the ingredientlist.
        /// </summary>
        /// <param name="rec"></param>
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

        private void btnChangePortionValues_Click(object sender, EventArgs e)
        {
            float portions = float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
            foreach (Ingredient ingredient in IngredientListBox.Items)
            {
                if (portions < 0)
                {
                    portions = 1;
                }
                else
                {
                    portions = float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
                }
                ingredient.Amount = (ingredient.Amount * portions);
            }
            this.IngredientListBox.Refresh();
        }
    }
}
