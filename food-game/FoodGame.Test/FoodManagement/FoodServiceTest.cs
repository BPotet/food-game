using FoodGame.FoodManagement.Models;
using FoodGame.FoodManagement.Services;

namespace FoodGameTest.FoodManagement;

public class FoodServiceTest
{
    
    [Fact]
    public void ShouldReturnAFood()
    {
        IFoodService foodService = new FoodService();
        
        Assert.IsType<Food>(foodService.GetFoods()[0]);
    }
}