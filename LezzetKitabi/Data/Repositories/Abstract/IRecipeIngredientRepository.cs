﻿using LezzetKitabi.Data.Repositories.Concrete;
using LezzetKitabi.Domain.Dtos.CrossTableDtos;
using LezzetKitabi.Domain.Dtos.IngredientDtos;
using LezzetKitabi.Domain.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetKitabi.Data.Repositories.Abstract
{
    public interface IRecipeIngredientRepository
    {
        public Task AddRangeAsync(List<AddRecipeIngredientDto> recipeIngredients);
        public Task<List<IngredientGetDto>> GetIngredientsByRecipeIdAsync(Guid recipeId);
    }
}
