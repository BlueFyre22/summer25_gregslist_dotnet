using System.ComponentModel.DataAnnotations;

namespace gregslist_dotnet.Models;

public class House
{
  public int? Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public int? Sqft { get; set; }
  public int? Bedrooms { get; set; }
  public double? Bathrooms { get; set; }
  [MaxLength(500), Url] public string ImgUrl { get; set; }
  public string Description { get; set; }
  public int? Price { get; set; }
  public string CreatorId { get; set; }
  public Account Creator { get; set; }
}