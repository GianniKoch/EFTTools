using System.Text.Json.Serialization;
using TarkovDevData.Models;

namespace TarkovDevData.Models;

public class DataBootstrapper {
  [JsonPropertyName("items")]
  public List<Item> Items { get; set; }

  [JsonPropertyName("ammo")]
  public List<Ammo> Ammo { get; set; }
}