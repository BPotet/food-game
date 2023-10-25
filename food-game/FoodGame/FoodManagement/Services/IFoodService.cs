using FoodGame.FoodManagement.Models;

namespace FoodGame.FoodManagement.Services;

public interface IFoodService
{
    public List<Food> GetFoods();
}