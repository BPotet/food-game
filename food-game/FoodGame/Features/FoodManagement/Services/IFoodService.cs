using FoodGame.Features.Common.Data.Models;

namespace FoodGame.Features.FoodManagement.Services;

public interface IFoodService
{
    public IReadOnlyCollection<Food> GetFoods();
}