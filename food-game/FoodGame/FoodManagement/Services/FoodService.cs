using FoodGame.FoodManagement.Models;

namespace FoodGame.FoodManagement.Services;

public class FoodService : IFoodService
{
    private static readonly string[] Names =
    {
        "McDall", "Kebab", "Tacos"
    };

    public List<Food> GetFoods()
    {
        return Enumerable.Range(1, 5).Select(index => new Food
            {
                Name = Names[Random.Shared.Next(Names.Length)]
            })
            .ToList();
    }
}