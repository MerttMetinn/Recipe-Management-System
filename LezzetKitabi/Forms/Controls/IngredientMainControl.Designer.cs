﻿namespace LezzetKitabi.Forms.Controls
{
    partial class IngredientMainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSearch = new Panel();
            button2 = new Button();
            textBoxSearch = new TextBox();
            comboBoxSort = new ComboBox();
            panelElements = new Panel();
            panelPage = new Panel();
            panelItems = new Panel();
            panelDown = new Panel();
            panelPrevius = new Panel();
            buttonPrevious = new Button();
            buttonNext = new Button();
            panelSort = new Panel();
            panelFilter = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            buttonPriceRangeAdd = new Button();
            textBoxMinPrice = new TextBox();
            label5 = new Label();
            textBoxMaxPrice = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            buttonStockRangeAdd = new Button();
            textBoxMinStock = new TextBox();
            label6 = new Label();
            textBoxMaxStock = new TextBox();
            panel2 = new Panel();
            buttonUnitAdd = new Button();
            comboBoxUnit = new ComboBox();
            label4 = new Label();
            panelCurrentFilters = new Panel();
            panelSearch.SuspendLayout();
            panelElements.SuspendLayout();
            panelPage.SuspendLayout();
            panelPrevius.SuspendLayout();
            panelSort.SuspendLayout();
            panelFilter.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.Transparent;
            panelSearch.Controls.Add(button2);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1334, 65);
            panelSearch.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(993, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 2;
            button2.Text = "Arama";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSearch.Location = new Point(195, 22);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Arama";
            textBoxSearch.Size = new Size(781, 33);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBoxSort
            // 
            comboBoxSort.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Alfabetik(A-Z)", "Alfabetik(Z-A)", "Ucuzdan Pahaliya", "Pahalidan Ucuza" });
            comboBoxSort.Location = new Point(690, 9);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(286, 25);
            comboBoxSort.TabIndex = 0;
            comboBoxSort.SelectedIndexChanged += ComboBoxSort_SelectedIndexChanged;
            // 
            // panelElements
            // 
            panelElements.BackColor = Color.Transparent;
            panelElements.Controls.Add(panelPage);
            panelElements.Controls.Add(panelSort);
            panelElements.Dock = DockStyle.Left;
            panelElements.Location = new Point(0, 65);
            panelElements.Name = "panelElements";
            panelElements.Size = new Size(1127, 730);
            panelElements.TabIndex = 2;
            // 
            // panelPage
            // 
            panelPage.BackColor = Color.Transparent;
            panelPage.Controls.Add(panelItems);
            panelPage.Controls.Add(panelDown);
            panelPage.Controls.Add(panelPrevius);
            panelPage.Controls.Add(buttonNext);
            panelPage.Location = new Point(0, 40);
            panelPage.Name = "panelPage";
            panelPage.Size = new Size(1126, 690);
            panelPage.TabIndex = 2;
            // 
            // panelItems
            // 
            panelItems.BackColor = Color.Transparent;
            panelItems.Dock = DockStyle.Left;
            panelItems.Location = new Point(48, 0);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(1041, 662);
            panelItems.TabIndex = 3;
            // 
            // panelDown
            // 
            panelDown.Dock = DockStyle.Bottom;
            panelDown.Location = new Point(48, 662);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(1078, 28);
            panelDown.TabIndex = 2;
            // 
            // panelPrevius
            // 
            panelPrevius.BackColor = Color.Transparent;
            panelPrevius.Controls.Add(buttonPrevious);
            panelPrevius.Dock = DockStyle.Left;
            panelPrevius.Location = new Point(0, 0);
            panelPrevius.Name = "panelPrevius";
            panelPrevius.Size = new Size(48, 690);
            panelPrevius.TabIndex = 1;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.FromArgb(255, 128, 0);
            buttonPrevious.FlatAppearance.BorderColor = Color.Black;
            buttonPrevious.FlatAppearance.BorderSize = 0;
            buttonPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            buttonPrevious.FlatStyle = FlatStyle.Flat;
            buttonPrevious.Location = new Point(-27, 156);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(91, 261);
            buttonPrevious.TabIndex = 0;
            buttonPrevious.Text = "<--";
            buttonPrevious.UseVisualStyleBackColor = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(255, 128, 0);
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Location = new Point(1060, 156);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(103, 261);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "-->";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // panelSort
            // 
            panelSort.BackColor = Color.Transparent;
            panelSort.Controls.Add(comboBoxSort);
            panelSort.Location = new Point(0, 0);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(1126, 40);
            panelSort.TabIndex = 1;
            // 
            // panelFilter
            // 
            panelFilter.BackgroundImageLayout = ImageLayout.None;
            panelFilter.Controls.Add(panel6);
            panelFilter.Controls.Add(panel5);
            panelFilter.Controls.Add(panel4);
            panelFilter.Controls.Add(panel2);
            panelFilter.Controls.Add(panelCurrentFilters);
            panelFilter.Dock = DockStyle.Left;
            panelFilter.Location = new Point(1127, 65);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(207, 730);
            panelFilter.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 64);
            panel6.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "Filtreler";
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonPriceRangeAdd);
            panel5.Controls.Add(textBoxMinPrice);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBoxMaxPrice);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 121);
            panel5.TabIndex = 0;
            // 
            // buttonPriceRangeAdd
            // 
            buttonPriceRangeAdd.Location = new Point(22, 86);
            buttonPriceRangeAdd.Name = "buttonPriceRangeAdd";
            buttonPriceRangeAdd.Size = new Size(166, 23);
            buttonPriceRangeAdd.TabIndex = 14;
            buttonPriceRangeAdd.Text = "Ekle";
            buttonPriceRangeAdd.UseVisualStyleBackColor = true;
            buttonPriceRangeAdd.Click += buttonPriceRangeAdd_Click;
            // 
            // textBoxMinPrice
            // 
            textBoxMinPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxMinPrice.Location = new Point(22, 54);
            textBoxMinPrice.Name = "textBoxMinPrice";
            textBoxMinPrice.PlaceholderText = "Min Price";
            textBoxMinPrice.Size = new Size(66, 23);
            textBoxMinPrice.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 55);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 5;
            label5.Text = "---";
            // 
            // textBoxMaxPrice
            // 
            textBoxMaxPrice.BackColor = Color.White;
            textBoxMaxPrice.Location = new Point(122, 54);
            textBoxMaxPrice.Name = "textBoxMaxPrice";
            textBoxMaxPrice.PlaceholderText = "Max Price";
            textBoxMaxPrice.Size = new Size(66, 23);
            textBoxMaxPrice.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 0;
            label2.Text = "Birim Fiyati:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(buttonStockRangeAdd);
            panel4.Controls.Add(textBoxMinStock);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBoxMaxStock);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 185);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 133);
            panel4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(9, 11);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 1;
            label3.Text = "Stok:";
            // 
            // buttonStockRangeAdd
            // 
            buttonStockRangeAdd.Location = new Point(19, 89);
            buttonStockRangeAdd.Name = "buttonStockRangeAdd";
            buttonStockRangeAdd.Size = new Size(166, 23);
            buttonStockRangeAdd.TabIndex = 13;
            buttonStockRangeAdd.Text = "Ekle";
            buttonStockRangeAdd.UseVisualStyleBackColor = true;
            buttonStockRangeAdd.Click += buttonStockRangeAdd_Click;
            // 
            // textBoxMinStock
            // 
            textBoxMinStock.Location = new Point(19, 49);
            textBoxMinStock.Name = "textBoxMinStock";
            textBoxMinStock.PlaceholderText = "Min Stock";
            textBoxMinStock.Size = new Size(66, 23);
            textBoxMinStock.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 52);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 9;
            label6.Text = "---";
            // 
            // textBoxMaxStock
            // 
            textBoxMaxStock.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaxStock.Location = new Point(119, 49);
            textBoxMaxStock.Name = "textBoxMaxStock";
            textBoxMaxStock.PlaceholderText = "Max Stock";
            textBoxMaxStock.Size = new Size(66, 23);
            textBoxMaxStock.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonUnitAdd);
            panel2.Controls.Add(comboBoxUnit);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 125);
            panel2.TabIndex = 15;
            // 
            // buttonUnitAdd
            // 
            buttonUnitAdd.Location = new Point(22, 85);
            buttonUnitAdd.Name = "buttonUnitAdd";
            buttonUnitAdd.Size = new Size(163, 23);
            buttonUnitAdd.TabIndex = 12;
            buttonUnitAdd.Text = "Ekle";
            buttonUnitAdd.UseVisualStyleBackColor = true;
            buttonUnitAdd.Click += buttonUnitAdd_Click;
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(22, 56);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(163, 23);
            comboBoxUnit.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 2;
            label4.Text = "Birim:";
            // 
            // panelCurrentFilters
            // 
            panelCurrentFilters.Dock = DockStyle.Bottom;
            panelCurrentFilters.Location = new Point(0, 443);
            panelCurrentFilters.Name = "panelCurrentFilters";
            panelCurrentFilters.Size = new Size(207, 287);
            panelCurrentFilters.TabIndex = 16;
            // 
            // IngredientMainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelFilter);
            Controls.Add(panelElements);
            Controls.Add(panelSearch);
            Name = "IngredientMainControl";
            Size = new Size(1334, 795);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelElements.ResumeLayout(false);
            panelPage.ResumeLayout(false);
            panelPrevius.ResumeLayout(false);
            panelSort.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Button button2;
        private TextBox textBoxSearch;
        private Panel panelElements;
        private Panel panelPage;
        private Panel panelPrevius;
        private Panel panelSort;
        private Panel panelItems;
        private Panel panelDown;
        private Panel panelFilter;
        private Label label2;
        private Label label1;
        private TextBox textBoxMaxPrice;
        private Label label5;
        private TextBox textBoxMinPrice;
        private Label label4;
        private Label label3;
        private Button buttonPriceRangeAdd;
        private Button buttonStockRangeAdd;
        private Button buttonUnitAdd;
        private ComboBox comboBoxUnit;
        private Label label6;
        private TextBox textBoxMaxStock;
        private TextBox textBoxMinStock;
        private Panel panel4;
        private Panel panel2;
        private Panel panelCurrentFilters;
        private Panel panel6;
        private Panel panel5;
        private ComboBox comboBoxSort;
        private Button buttonNext;
        private Button buttonPrevious;
    }
}
