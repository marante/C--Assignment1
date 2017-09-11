using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        FormMain mainForm = null;
        Recipe recipe = null;
        public FormIngredient()
        {
            InitializeComponent();
        }

        public FormIngredient(FormMain mainForm)
        {
            InitializeComponent();
        }

        public FormIngredient(FormMain mainForm, Recipe recipe)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.recipe = recipe;

            foreach (var ingredient in recipe.Ingredients)
            {
                ingredients.Add(ingredient);
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
            this.mainForm.SendIngredients(ingredients);
            this.Close();
        }

        private void BtnIngredientCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngredientDelete_Click(object sender, EventArgs e)
        {
            var selIngredient = (Ingredient) IngredientListBox.SelectedItem;
            IngredientListBox.Items.Remove(IngredientListBox.SelectedItem);
            ingredients.Remove(selIngredient);
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
            ingredients.Add(ingredient);
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
