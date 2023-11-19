using FoodGame.Features.Common.Data.Models;
using FoodGame.Features.FoodManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodGame.Features.FoodManagement.Controllers;

[ApiController]
[Route("food")]
public class FoodController : ControllerBase
{
    private readonly IFoodService _foodService;

    public FoodController(IFoodService foodService)
    {
        _foodService = foodService;
    }

    [HttpGet(Name = "GetFoods")]
    public IEnumerable<Food> Get()
    {
        return _foodService.GetFoods();
    }
}