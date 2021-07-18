using Microsoft.AspNetCore.Http;
 
using MongoDB.Entities;
using System.Text.Json.Serialization;

namespace Domain
{
  public class Pet : BaseEntity
  {

    public string Name { get; set; }
    public string Owner { get; set; }
    public string FileName { get; set; }
    public int Age { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public string Category { get; set; }
    public string Breed { get; set; }
    public string CreatorEmail { get; set; }
    public string Description { get; set; }
    [JsonIgnore]
    public IFormFile Image { get; set; }
    [JsonIgnore]
    public Coordinates2D Location { get; set; }
    public void PrepareForInsertion()
    {
      this.Location = new Coordinates2D(Longitude, Latitude);
      this.Image = null;
    }     
    //GeoJson.Point(new GeoJson2DCoordinates(lng, lat)).ToBsonDocument()

  }
}
