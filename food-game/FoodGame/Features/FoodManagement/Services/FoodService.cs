using FoodGame.Data.Context;
using FoodGame.Features.Common.Data.Models;

namespace FoodGame.Features.FoodManagement.Services;

public class FoodService : IFoodService
{
    private readonly ApplicationDbContext _dbContext;

    public FoodService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IReadOnlyCollection<Food> GetFoods()
    {
        return _dbContext.Foods.ToList();
    }
}