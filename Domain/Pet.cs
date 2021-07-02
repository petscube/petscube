using Microsoft.AspNetCore.Http;
 
using MongoDB.Entities;
namespace Domain
{
  public class Pet : BaseEntity
  {

    public string Name { get; set; }
    public string FileName { get; set; }
    public int Age { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Contact { get; set; }
    public string Gender { get; set; }
    public string Category { get; set; }
    public string Breed { get; set; }
    public string Description { get; set; }
    public IFormFile Image { get; set; }
    public Coordinates2D Location
    {
      get
      {
        return new Coordinates2D(Longitude, Latitude);
      }
    }
    //GeoJson.Point(new GeoJson2DCoordinates(lng, lat)).ToBsonDocument()

  }
}
