﻿namespace LezzetKitabi.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            buttonIngredient = new Button();
            buttonRecipe = new Button();
            buttonSearch = new Button();
            panelLogo = new Panel();
            button1 = new Button();
            panelForms = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 56);
            panelMenu.Controls.Add(buttonIngredient);
            panelMenu.Controls.Add(buttonRecipe);
            panelMenu.Controls.Add(buttonSearch);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 567);
            panelMenu.TabIndex = 0;
            // 
            // buttonIngredient
            // 
            buttonIngredient.Dock = DockStyle.Top;
            buttonIngredient.FlatAppearance.BorderSize = 0;
            buttonIngredient.FlatStyle = FlatStyle.Flat;
            buttonIngredient.ForeColor = Color.White;
            buttonIngredient.Location = new Point(0, 230);
            buttonIngredient.Name = "buttonIngredient";
            buttonIngredient.Size = new Size(214, 75);
            buttonIngredient.TabIndex = 2;
            buttonIngredient.Tag = "Ingredient";
            buttonIngredient.Text = "Malzemelerim";
            buttonIngredient.UseVisualStyleBackColor = true;
            buttonIngredient.Click += buttonIngredient_Click;
            // 
            // buttonRecipe
            // 
            buttonRecipe.Dock = DockStyle.Top;
            buttonRecipe.FlatAppearance.BorderSize = 0;
            buttonRecipe.FlatStyle = FlatStyle.Flat;
            buttonRecipe.ForeColor = Color.White;
            buttonRecipe.Location = new Point(0, 155);
            buttonRecipe.Name = "buttonRecipe";
            buttonRecipe.Size = new Size(214, 75);
            buttonRecipe.TabIndex = 1;
            buttonRecipe.Tag = "Recipe";
            buttonRecipe.Text = "Tariflerim";
            buttonRecipe.UseVisualStyleBackColor = true;
            buttonRecipe.Click += buttonRecipe_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Top;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(0, 80);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(214, 75);
            buttonSearch.TabIndex = 0;
            buttonSearch.Tag = "Search";
            buttonSearch.Text = "Arama";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(button1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(214, 80);
            panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "►";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelForms
            // 
            panelForms.Dock = DockStyle.Fill;
            panelForms.Location = new Point(214, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(932, 567);
            panelForms.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 567);
            Controls.Add(panelForms);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Lezzet Kitabı";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelMenu;
        private Button buttonSearch;
        private Panel panelLogo;
        private Button buttonIngredient;
        private Button buttonRecipe;
        private Button button1;
        private Panel panelForms;
    }
}