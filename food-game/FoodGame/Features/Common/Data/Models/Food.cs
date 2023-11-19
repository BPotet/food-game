using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodGame.Features.Common.Data.Models;

[Table("food")]
public class Food
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
}