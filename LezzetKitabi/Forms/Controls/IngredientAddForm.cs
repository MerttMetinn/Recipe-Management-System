﻿using LezzetKitabi.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using LezzetKitabi.Domain.Dtos.IngredientDtos;
using LezzetKitabi.Domain.Enums;

namespace LezzetKitabi.Forms.Controls
{
    public partial class IngredientAddForm : UserControl
    {
        private readonly IIngredientService _ingredientService;
        public IngredientAddForm(IServiceProvider serviceProvider)
        {
            _ingredientService = serviceProvider.GetRequiredService<IIngredientService>();
            InitializeComponent();
            cmbUnit.DataSource = Enum.GetValues(typeof(UnitType));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredientName.Text) ||
                string.IsNullOrWhiteSpace(txtTotalQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            IngredientAddDto ingredient = new IngredientAddDto()
            {
                IngredientName = txtIngredientName.Text,
                TotalQuantity = txtTotalQuantity.Text,
                Unit = cmbUnit.SelectedItem.ToString(),
            };

            if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                ingredient.UnitPrice = unitPrice;

                _ingredientService.AddIngredient(ingredient);

                MessageBox.Show("Malzeme başarıyla eklendi!");

                txtIngredientName.Clear();
                txtTotalQuantity.Clear();
                txtUnitPrice.Clear();
                cmbUnit.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
            }
        }
    }
}
