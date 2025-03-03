﻿using LezzetKitabi.Data.Repositories.Abstract;
using LezzetKitabi.Data.Repositories.Concrete;
using LezzetKitabi.Domain.Dtos.IngredientDtos;
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
                Image = recipeAddDto.Image
            };

            _recipeRepository.AddEntity(recipe);
            return recipe.Id;
        }
        public async Task<List<RecipeViewGetDto>> GetAllRecipesByOrderAsync(RecipeSortingType _type, List<FilterCriteria> filterCriteriaList = null, int page = -1)
        {
            var recipes = await _recipeRepository.GetAllRecipesByOrderAsync(_type, filterCriteriaList, page);
            return recipes;
        }
        
        public bool DeleteRecipe(Guid id)
        {
            bool isDeleted = _recipeRepository.DeleteAsync(id).Result;

            return isDeleted;
        }
        public async Task<RecipeGetDto?> GetRecipeByNameAsync(string name)
        {
            var recipe = await _recipeRepository.GetRecipeByNameAsync(name);

            if (recipe == null)
            {
                return null;
            }

            RecipeGetDto recipeGetDto = new RecipeGetDto()
            {
                Id = recipe.Id,
                RecipeName = recipe.RecipeName,
                Category = recipe.Category,
                Instructions = recipe.Instructions,
                PreparationTime = recipe.PreparationTime,
            };

            return recipeGetDto;
        }
        public async Task<bool> UpdateRecipeAsync(RecipeUpdateDto recipeUpdateDto)
        {
            return await _recipeRepository.UpdateRecipeAsync(recipeUpdateDto);
        }
    }
}
