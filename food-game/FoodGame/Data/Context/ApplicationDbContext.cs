using FoodGame.Features.Common.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodGame.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Food> Foods { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}