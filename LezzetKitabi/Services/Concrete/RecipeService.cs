﻿using LezzetKitabi.Data.Repositories.Abstract;
using LezzetKitabi.Data.Repositories.Concrete;
using LezzetKitabi.Domain.Dtos.RecipeDtos;
using LezzetKitabi.Domain.Entities;
using LezzetKitabi.Domain.Enums;
using LezzetKitabi.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetKitabi.Services.Concrete
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        public Guid AddRecipe(RecipeAddDto recipeAddDto)
        {
            Recipe recipe = new Recipe()
            {
                RecipeName = recipeAddDto.RecipeName,
                Category = recipeAddDto.Category,
                PreparationTime = recipeAddDto.PreparationTime,
                Instructions = recipeAddDto.Instructions,
            };

            _recipeRepository.AddEntity(recipe);
            return recipe.Id;
        }
        public async Task<List<Recipe>> GetAllRecipesAsync(RecipeSortingType _type)
        {
            return await _recipeRepository.GetAllRecipesByOrderAsync(_type);
        }
        public bool DeleteRecipe(Guid id)
        {
            bool isDeleted = _recipeRepository.DeleteAsync(id).Result;

            return isDeleted;
        }
    }
}
