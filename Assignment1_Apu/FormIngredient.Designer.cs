namespace Assignment1_Apu
{
    partial class FormIngredient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingredientTextbox = new System.Windows.Forms.TextBox();
            this.IngredientAmount = new System.Windows.Forms.TextBox();
            this.IngredientListBox = new System.Windows.Forms.ListBox();
            this.BtnIngredientAdd = new System.Windows.Forms.Button();
            this.BtnIngredientDelete = new System.Windows.Forms.Button();
            this.BtnIngredientOk = new System.Windows.Forms.Button();
            this.BtnIngredientCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAmountOfPortions = new System.Windows.Forms.ComboBox();
            this.btnChangePortionValues = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePortionValues);
            this.groupBox1.Controls.Add(this.cmbAmountOfPortions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ingredientTextbox);
            this.groupBox1.Controls.Add(this.IngredientAmount);
            this.groupBox1.Controls.Add(this.IngredientListBox);
            this.groupBox1.Controls.Add(this.BtnIngredientAdd);
            this.groupBox1.Controls.Add(this.BtnIngredientDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // ingredientTextbox
            // 
            this.ingredientTextbox.Location = new System.Drawing.Point(78, 19);
            this.ingredientTextbox.Name = "ingredientTextbox";
            this.ingredientTextbox.Size = new System.Drawing.Size(261, 20);
            this.ingredientTextbox.TabIndex = 10;
            // 
            // IngredientAmount
            // 
            this.IngredientAmount.Location = new System.Drawing.Point(7, 19);
            this.IngredientAmount.Name = "IngredientAmount";
            this.IngredientAmount.Size = new System.Drawing.Size(63, 20);
            this.IngredientAmount.TabIndex = 9;
            // 
            // IngredientListBox
            // 
            this.IngredientListBox.DisplayMember = "DisplayIngredient";
            this.IngredientListBox.FormattingEnabled = true;
            this.IngredientListBox.Location = new System.Drawing.Point(7, 45);
            this.IngredientListBox.Name = "IngredientListBox";
            this.IngredientListBox.Size = new System.Drawing.Size(332, 277);
            this.IngredientListBox.TabIndex = 8;
            // 
            // BtnIngredientAdd
            // 
            this.BtnIngredientAdd.Location = new System.Drawing.Point(345, 19);
            this.BtnIngredientAdd.Name = "BtnIngredientAdd";
            this.BtnIngredientAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnIngredientAdd.TabIndex = 4;
            this.BtnIngredientAdd.Text = "Add";
            this.BtnIngredientAdd.UseVisualStyleBackColor = true;
            this.BtnIngredientAdd.Click += new System.EventHandler(this.BtnIngredientAdd_Click);
            // 
            // BtnIngredientDelete
            // 
            this.BtnIngredientDelete.Location = new System.Drawing.Point(345, 160);
            this.BtnIngredientDelete.Name = "BtnIngredientDelete";
            this.BtnIngredientDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnIngredientDelete.TabIndex = 2;
            this.BtnIngredientDelete.Text = "Delete";
            this.BtnIngredientDelete.UseVisualStyleBackColor = true;
            this.BtnIngredientDelete.Click += new System.EventHandler(this.BtnIngredientDelete_Click);
            // 
            // BtnIngredientOk
            // 
            this.BtnIngredientOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnIngredientOk.Location = new System.Drawing.Point(12, 384);
            this.BtnIngredientOk.Name = "BtnIngredientOk";
            this.BtnIngredientOk.Size = new System.Drawing.Size(141, 23);
            this.BtnIngredientOk.TabIndex = 0;
            this.BtnIngredientOk.Text = "OK";
            this.BtnIngredientOk.UseVisualStyleBackColor = true;
            this.BtnIngredientOk.Click += new System.EventHandler(this.BtnIngredientOk_Click);
            // 
            // BtnIngredientCancel
            // 
            this.BtnIngredientCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnIngredientCancel.Location = new System.Drawing.Point(210, 384);
            this.BtnIngredientCancel.Name = "BtnIngredientCancel";
            this.BtnIngredientCancel.Size = new System.Drawing.Size(141, 23);
            this.BtnIngredientCancel.TabIndex = 1;
            this.BtnIngredientCancel.Text = "Cancel";
            this.BtnIngredientCancel.UseVisualStyleBackColor = true;
            this.BtnIngredientCancel.Click += new System.EventHandler(this.BtnIngredientCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Num. of ingredients";
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.AutoSize = true;
            this.lblNumOfIngredients.Location = new System.Drawing.Point(226, 21);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(125, 13);
            this.lblNumOfIngredients.TabIndex = 6;
            this.lblNumOfIngredients.Text = "No ingredients added yet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Portions";
            // 
            // cmbAmountOfPortions
            // 
            this.cmbAmountOfPortions.FormattingEnabled = true;
            this.cmbAmountOfPortions.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbAmountOfPortions.Location = new System.Drawing.Point(345, 68);
            this.cmbAmountOfPortions.Name = "cmbAmountOfPortions";
            this.cmbAmountOfPortions.Size = new System.Drawing.Size(75, 21);
            this.cmbAmountOfPortions.TabIndex = 13;
            // 
            // btnChangePortionValues
            // 
            this.btnChangePortionValues.Location = new System.Drawing.Point(345, 95);
            this.btnChangePortionValues.Name = "btnChangePortionValues";
            this.btnChangePortionValues.Size = new System.Drawing.Size(75, 23);
            this.btnChangePortionValues.TabIndex = 14;
            this.btnChangePortionValues.Text = "Change portion";
            this.btnChangePortionValues.UseVisualStyleBackColor = true;
            this.btnChangePortionValues.Click += new System.EventHandler(this.BtnChangePortionValues_Click);
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.lblNumOfIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngredientOk);
            this.Controls.Add(this.BtnIngredientCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormIngredient";
            this.Text = "FormIngredient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnIngredientOk;
        private System.Windows.Forms.Button BtnIngredientAdd;
        private System.Windows.Forms.Button BtnIngredientDelete;
        private System.Windows.Forms.Button BtnIngredientCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.TextBox IngredientAmount;
        private System.Windows.Forms.TextBox ingredientTextbox;
        private System.Windows.Forms.ListBox IngredientListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAmountOfPortions;
        private System.Windows.Forms.Button btnChangePortionValues;
    }
}