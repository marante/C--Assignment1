using System;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRecipeAddIngredients = new System.Windows.Forms.Button();
            this.RecipeDropdownCategory = new System.Windows.Forms.ComboBox();
            this.RecipeTextbox = new System.Windows.Forms.TextBox();
            this.AddNewRecipe = new System.Windows.Forms.GroupBox();
            this.MealTypeDropdownList = new System.Windows.Forms.ComboBox();
            this.RecipeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddRecipe = new System.Windows.Forms.Button();
            this.RecipeListbox = new System.Windows.Forms.ListBox();
            this.BtnEditRecipe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDeleteRecipe = new System.Windows.Forms.Button();
            this.AddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRecipeAddIngredients
            // 
            this.BtnRecipeAddIngredients.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRecipeAddIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRecipeAddIngredients.Location = new System.Drawing.Point(358, 61);
            this.BtnRecipeAddIngredients.Name = "BtnRecipeAddIngredients";
            this.BtnRecipeAddIngredients.Size = new System.Drawing.Size(115, 24);
            this.BtnRecipeAddIngredients.TabIndex = 0;
            this.BtnRecipeAddIngredients.Text = "Add ingredients";
            this.BtnRecipeAddIngredients.UseVisualStyleBackColor = false;
            this.BtnRecipeAddIngredients.Click += new System.EventHandler(this.BtnRecipeAddIngredients_Click);
            // 
            // RecipeDropdownCategory
            // 
            this.RecipeDropdownCategory.DataSource = new Assignment1_Apu.Enums.Dish[] {
        Assignment1_Apu.Enums.Dish.Meat,
        Assignment1_Apu.Enums.Dish.Bird,
        Assignment1_Apu.Enums.Dish.Fish,
        Assignment1_Apu.Enums.Dish.Vegetarian,
        Assignment1_Apu.Enums.Dish.Vegan};
            this.RecipeDropdownCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecipeDropdownCategory.FormattingEnabled = true;
            this.RecipeDropdownCategory.Location = new System.Drawing.Point(133, 61);
            this.RecipeDropdownCategory.Name = "RecipeDropdownCategory";
            this.RecipeDropdownCategory.Size = new System.Drawing.Size(105, 24);
            this.RecipeDropdownCategory.TabIndex = 1;
            // 
            // RecipeTextbox
            // 
            this.RecipeTextbox.Location = new System.Drawing.Point(21, 117);
            this.RecipeTextbox.Multiline = true;
            this.RecipeTextbox.Name = "RecipeTextbox";
            this.RecipeTextbox.Size = new System.Drawing.Size(452, 257);
            this.RecipeTextbox.TabIndex = 2;
            // 
            // AddNewRecipe
            // 
            this.AddNewRecipe.Controls.Add(this.MealTypeDropdownList);
            this.AddNewRecipe.Controls.Add(this.RecipeNameTextBox);
            this.AddNewRecipe.Controls.Add(this.label2);
            this.AddNewRecipe.Controls.Add(this.label1);
            this.AddNewRecipe.Controls.Add(this.RecipeTextbox);
            this.AddNewRecipe.Controls.Add(this.BtnRecipeAddIngredients);
            this.AddNewRecipe.Controls.Add(this.RecipeDropdownCategory);
            this.AddNewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewRecipe.Location = new System.Drawing.Point(12, 44);
            this.AddNewRecipe.Name = "AddNewRecipe";
            this.AddNewRecipe.Size = new System.Drawing.Size(484, 419);
            this.AddNewRecipe.TabIndex = 3;
            this.AddNewRecipe.TabStop = false;
            this.AddNewRecipe.Text = "Add New Recipe";
            // 
            // MealTypeDropdownList
            // 
            this.MealTypeDropdownList.BackColor = System.Drawing.SystemColors.Control;
            this.MealTypeDropdownList.DataSource = new Assignment1_Apu.Enums.MealType[] {
        Assignment1_Apu.Enums.MealType.Appetizer,
        Assignment1_Apu.Enums.MealType.MainCourse,
        Assignment1_Apu.Enums.MealType.Dessert};
            this.MealTypeDropdownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MealTypeDropdownList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MealTypeDropdownList.FormattingEnabled = true;
            this.MealTypeDropdownList.Location = new System.Drawing.Point(244, 62);
            this.MealTypeDropdownList.Name = "MealTypeDropdownList";
            this.MealTypeDropdownList.Size = new System.Drawing.Size(105, 24);
            this.MealTypeDropdownList.TabIndex = 5;
            // 
            // RecipeNameTextBox
            // 
            this.RecipeNameTextBox.Location = new System.Drawing.Point(133, 27);
            this.RecipeNameTextBox.Name = "RecipeNameTextBox";
            this.RecipeNameTextBox.Size = new System.Drawing.Size(340, 22);
            this.RecipeNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of recipe";
            // 
            // BtnAddRecipe
            // 
            this.BtnAddRecipe.Location = new System.Drawing.Point(25, 487);
            this.BtnAddRecipe.Name = "BtnAddRecipe";
            this.BtnAddRecipe.Size = new System.Drawing.Size(460, 23);
            this.BtnAddRecipe.TabIndex = 3;
            this.BtnAddRecipe.Text = "Add recipe";
            this.BtnAddRecipe.UseVisualStyleBackColor = true;
            this.BtnAddRecipe.Click += new System.EventHandler(this.BtnRecipeAdd_Click);
            // 
            // RecipeListbox
            // 
            this.RecipeListbox.DisplayMember = "DisplayString";
            this.RecipeListbox.FormattingEnabled = true;
            this.RecipeListbox.Location = new System.Drawing.Point(533, 124);
            this.RecipeListbox.Name = "RecipeListbox";
            this.RecipeListbox.Size = new System.Drawing.Size(452, 329);
            this.RecipeListbox.TabIndex = 4;
            // 
            // BtnEditRecipe
            // 
            this.BtnEditRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditRecipe.Location = new System.Drawing.Point(623, 486);
            this.BtnEditRecipe.Name = "BtnEditRecipe";
            this.BtnEditRecipe.Size = new System.Drawing.Size(136, 24);
            this.BtnEditRecipe.TabIndex = 5;
            this.BtnEditRecipe.Text = "Edit";
            this.BtnEditRecipe.UseVisualStyleBackColor = false;
            this.BtnEditRecipe.Click += new System.EventHandler(this.BtnEditRecipe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 76);
            this.label4.MaximumSize = new System.Drawing.Size(60, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of ingred.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(839, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dish";
            // 
            // BtnDeleteRecipe
            // 
            this.BtnDeleteRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteRecipe.Location = new System.Drawing.Point(778, 486);
            this.BtnDeleteRecipe.Name = "BtnDeleteRecipe";
            this.BtnDeleteRecipe.Size = new System.Drawing.Size(136, 24);
            this.BtnDeleteRecipe.TabIndex = 11;
            this.BtnDeleteRecipe.Text = "Delete";
            this.BtnDeleteRecipe.UseVisualStyleBackColor = false;
            this.BtnDeleteRecipe.Click += new System.EventHandler(this.BtnDeleteRecipe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 544);
            this.Controls.Add(this.BtnDeleteRecipe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEditRecipe);
            this.Controls.Add(this.RecipeListbox);
            this.Controls.Add(this.BtnAddRecipe);
            this.Controls.Add(this.AddNewRecipe);
            this.Name = "FormMain";
            this.Text = "Apu\'s Cook Book";
            this.AddNewRecipe.ResumeLayout(false);
            this.AddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRecipeAddIngredients;
        private System.Windows.Forms.ComboBox RecipeDropdownCategory;
        private System.Windows.Forms.TextBox RecipeTextbox;
        private System.Windows.Forms.GroupBox AddNewRecipe;
        private System.Windows.Forms.TextBox RecipeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddRecipe;
        private System.Windows.Forms.ListBox RecipeListbox;
        private System.Windows.Forms.Button BtnEditRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MealTypeDropdownList;
        private Label label7;
        private Button BtnDeleteRecipe;
    }
}

