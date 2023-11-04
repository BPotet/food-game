using FoodGame.Features.Common.Data.Models;
using FoodGame.Features.FoodManagement.Services;

namespace FoodGameTest.FoodManagement;

public class FoodServiceTest
{
    
    [Fact]
    public void ShouldReturnAFood()
    {
        IFoodService foodService = new FoodService(null);
        
        Assert.IsType<Food>(foodService.GetFoods().ToList()[0]);
    }
}